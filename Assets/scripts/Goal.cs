using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Tor");
    }
}
