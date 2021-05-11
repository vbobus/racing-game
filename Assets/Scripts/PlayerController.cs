using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 15.0f;
    private float turnSpeed = 75.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets horizontal & vertical axis input
        horizontalInput = Input.GetAxis("Horizontal"); 
        forwardInput = Input.GetAxis("Vertical");      

       
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);    //moves the vehicle forward based on vertical input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);     //rotates the vehicle based on horizontal inputs
    }
}
