using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    
    
        public float walkSpeed = 10;
    public float turnSpeed = 10;
    // Start is called before the first frame update
    void Start()
        {

        }

    // Update is called once per frame
    void Update()
    {

        float horizontal_movement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float vertical_movement = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime;


        transform.Translate(0, 0, vertical_movement);
        transform.Rotate(0, horizontal_movement, 0);
            
            }
   
}
