using System.Collections;
using System.IO.Pipes;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float horizontalInput;
    const float xRange = 21.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        
         
        horizontalInput = Input.GetAxis("Horizontal");
        
        switch (transform.position.x)
        {
            case > xRange: // when player is out of bounds on the x-axis, reset position
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
                horizontalInput *= 0.1f;
                break;
            case < -xRange: // when player is out of bounds on the x-axis, reset position
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
                horizontalInput *= 0.1f;
                break;
            default: // player moves horizontaly
                transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
                break;
        }

        /*  better solution for keeping the player in bounds without stuttering
         // player moves horizontaly
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        // variable for x to keep the player in bounds by clamping the x position to the xRange
        float clampedX = Mathf.Clamp(transform.position.x, -xRange, xRange);
        // update the player's position with the clamped x value
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
        */




    }
}
