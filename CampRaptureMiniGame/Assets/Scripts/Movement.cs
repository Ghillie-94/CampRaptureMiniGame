using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public float forceStrength;
    public GameObject JoystickContainer;
    public Vector2 inputDirection;
    

   
    public void FixedUpdate()
    {
        inputDirection = JoystickContainer.GetComponent<joystick>().InputDirection;
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in set direction with the set force strength
        ourRigidbody.AddForce(inputDirection * forceStrength);

    }

    public void MoveUp()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in set direction with the set force strength
        ourRigidbody.AddForce(inputDirection * forceStrength);
    }

    public void MoveLeft()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in set direction with the set force strength
        ourRigidbody.AddForce(inputDirection * forceStrength);
    }

    public void MoveRight()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in set direction with the set force strength
        ourRigidbody.AddForce(inputDirection * forceStrength);
    }

    public void MoveDown()
    {
        // Get the rigidbody that we'll be using for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        //move in set direction with the set force strength
        ourRigidbody.AddForce(inputDirection * forceStrength);
    }



    
}
