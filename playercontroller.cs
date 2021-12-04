using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        //rotates the car based on horizontal input
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * 20);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);    }
}
