using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    private float rotationSpeed = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector2.up * rotationSpeed * Time.deltaTime);
        transform.RotateAround(Vector3.forward,90);
    }
}
