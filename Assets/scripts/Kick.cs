using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Kick : MonoBehaviour
{
    public float angleF = 15;
    public float speed = 300;
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
        transform.Rotate(Mathf.Sin(speed * timesincestart) * (float)(Convert.ToInt16(Input.GetButtonDown("Fire2"))) * angleF, 0, 0, Space.Self);

        if (Input.GetButtonDown("Fire2"))
            Debug.Log("bla");
    }
}
