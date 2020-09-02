using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    public float angle = 15;
    public float speed = 50;
    private float timesincestart = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timesincestart += Time.deltaTime;


        transform.localRotation = Quaternion.identity;
        transform.Rotate(Mathf.Sin(speed*timesincestart) * angle,0,0,Space.Self);
       

    }
}
