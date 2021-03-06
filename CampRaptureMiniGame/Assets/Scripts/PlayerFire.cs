using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Unity editior variable
    public GameObject projectilePrefab;
    private Vector2 projectileDirection;
    public GameObject JoystickContainer;
    public float projectileSpeed;
    public float goalTime;
    private float startTime;

    //KEYBOARD/GAMEPAD INPUT
    //condition: when the player presses a key or a button...
    void Update()
    {
        projectileDirection = JoystickContainer.GetComponent<joystick>().InputDirection;
        if ((projectileDirection.x != 0 || projectileDirection.y != 0) && (Time.time >= startTime + goalTime))
        {
            FireProjectile();
            startTime = Time.time;

        }


    }

    // ACTION: fire a projectile
    public void FireProjectile()
    {
        //clone the projectile
        //declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        //position the projectile on the player... tranform is the location of the script (the player object)
        clonedProjectile.transform.position = transform.position; //optional: add an offset (use a public variable)

        //fire in a direction
        //declare a variable to hold the cloned obeject's rigidbody
        Rigidbody2D projectileRigidbody;
        //get the rigidbody from our cloned projectile and store it
        projectileRigidbody = clonedProjectile.GetComponent<Rigidbody2D>();
        // Set the velocity on the rigidbody to the editor setting
        projectileRigidbody.velocity = projectileDirection * projectileSpeed;


    }


    


}
