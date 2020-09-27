using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalkeeper : MonoBehaviour
{
    public float walkSpeed = 9;
    public float sidewaysSpeed = 6;
    public float speed = 50;
    private float timesincestart = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        float vertical_movement = Mathf.Sin(speed * timesincestart) * walkSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical_movement);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
