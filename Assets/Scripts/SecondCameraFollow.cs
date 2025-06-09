using UnityEngine;

public class SecondCameraFollow : MonoBehaviour
{
    public GameObject player;
    

    private Vector3 offset = new Vector3(0, 5f, 7f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Add a offset to put the camera behind the player with a new Vector3
        transform.position = player.transform.position + offset;    
    }
}
