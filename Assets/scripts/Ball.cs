using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{ 
    public void Reset()
    {
        transform.position = new Vector3(Random.Range(-15f, 15f), 2, Random.Range(-32f, -4f));


    }
}
