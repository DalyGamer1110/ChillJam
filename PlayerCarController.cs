using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 200f;

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move the car forward and backward
        transform.Translate(Vector2.up * verticalInput * speed * Time.deltaTime);

        // Rotate the car left and right
        transform.Rotate(Vector3.forward * -horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
