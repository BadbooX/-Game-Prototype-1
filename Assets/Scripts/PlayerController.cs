using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera cam1;
    public Camera cam2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {   // get the horizontal && vertical axis
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moove the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown("f") && cam1.enabled){
            cam1.enabled = false;
            cam2.enabled = true; 
        }else if(Input.GetKeyDown("f") && !cam1.enabled){
            cam2.enabled = false;
            cam1.enabled = true; 
        }
    }
}
