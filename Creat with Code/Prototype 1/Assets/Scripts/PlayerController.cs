using Unity.Hierarchy;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float playerSpeed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get palyer input
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed * forwardInput);
        // rotate vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
