using UnityEngine;
using UnityEngine.UIElements;

public class PropellerRotationX : MonoBehaviour
{
    public GameObject propeller;
    public float rotationSpeedPropeller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(0,0,rotationSpeedPropeller);
    }
}
