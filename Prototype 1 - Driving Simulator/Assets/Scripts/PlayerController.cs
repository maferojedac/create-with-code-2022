using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class handles player movement

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 60f;
    private float horizontalInput;	// Stores the horizontal input from the player.
    private float forwardInput;	// Stores the vertical input from the player.

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");  // Gets the horizontal input from the player
        forwardInput = Input.GetAxis("Vertical");	// Gets the vertical input from the player.

        // Move the vehicle forward 20 meters per second.
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // Turn the vehicle left or right based on the horizontal input.
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}