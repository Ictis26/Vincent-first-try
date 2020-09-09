using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Goal : MonoBehaviour
{
    public Man player;
    private GameObject Körper;
    private GameObject Tor;
    private GameObject Quad;

    private GameObject canvas; 

    void Start()
    {
        Canvas render = gameObject.GetComponentInChildren<Canvas>();
        canvas = render.gameObject;
        canvas.SetActive(false);
    }
    void OnTriggerEnter(Collider col)
    {
        canvas.SetActive(true);
      
    }

    private void Reset()
    {
        player.Reset();
    }
}
