using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
   private float speed = 5.0f;
    private  float turnspeed;
   private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
    
        // We'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //we'll turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * horizontalInput);

    }
}
