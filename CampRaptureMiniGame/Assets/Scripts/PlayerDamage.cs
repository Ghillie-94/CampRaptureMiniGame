using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public GameObject projectilePrefab;

    //CONDITION: when the projectile hits a certain object type... (enemy)
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //Check if the object we collided with has the tag we are looking for (Enemy)
        if (otherCollider.CompareTag("Enemy"))
        {

            Debug.Log("Killing enemy");
            //perform our action
            KillEnemy(otherCollider.gameObject);

            Destroy(gameObject);
        }
    }

    //ACTION: Destroy an object (enemy)
    public void KillEnemy(GameObject enemy)
    {
        Destroy(enemy);
        /* // Explosion animation: spawn a prefab of explosion
        //clone the projectile
        //declare a variable to hold the cloned object
        GameObject clonedProjectile;
        // Use Instantiate to clone the projectile and keep the result in our variable
        clonedProjectile = Instantiate(projectilePrefab);

        //position the projectile on the player... tranform is the location of the script (the player object)
        clonedProjectile.transform.position = transform.position; //optional: add an offset (use a public variable)*/

          
    }
}
