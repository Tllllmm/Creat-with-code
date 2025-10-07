using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // reference to GameObject Player
    public GameObject Player;
    // initialise new Vector for camera offset
    private Vector3 offset= new Vector3(0, 5, -9);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Set the position of the camera       and      add the vector "offset" to offset the cameras position
        transform.position = Player.transform.position + offset;
    }
}
