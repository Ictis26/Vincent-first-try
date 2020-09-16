using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leg : MonoBehaviour
{
    public float angleF= 15;
    public float speed = 50;
    private float timesincestart = 0;
    public float angleS = 8;
    public float angleQ = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    


    // Update is called once per frame
    void Update()
    {

        timesincestart += Time.deltaTime;
        transform.localRotation = Quaternion.identity;
        transform.Rotate(Mathf.Sin(speed * timesincestart) * Input.GetAxis("Vertical") * angleF, 0, 0, Space.Self);
        transform.Rotate(angleQ*Mathf.Sin(speed * timesincestart) * Input.GetAxis("Horizontal") , 0, angleS *Mathf.Sin(speed * timesincestart) * Input.GetAxis("Horizontal") , Space.Self);

        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("Kick");
        }
    }
    
    
}
