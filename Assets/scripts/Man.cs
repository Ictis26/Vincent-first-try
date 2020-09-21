using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{


    public float walkSpeed = 9;
    public float turnSpeed = 900;
    public float sidewaysSpeed = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontal_turning = (Input.GetAxis("Mouse X") + Input.GetAxis("JoystickLookX")) * turnSpeed * Time.deltaTime;
        float vertical_movement = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime;
        float horizontal_movemnt = Input.GetAxis("Horizontal") * sidewaysSpeed * Time.deltaTime;

        transform.Translate(0, 0, vertical_movement);
        transform.Translate(horizontal_movemnt, 0, 0);
        transform.Rotate(0, horizontal_turning, 0);

       


           
       

    
    }

    public void Reset()
    {
        transform.position = new Vector3(Random.Range(-25f, 25f), 0.992f, Random.Range(-42f, 6f));

    }
}
