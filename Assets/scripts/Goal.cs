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
    public GameObject effect;
    public Transform[] fxspots;

    void Start()
    {
        
        Canvas render = gameObject.GetComponentInChildren<Canvas>();
        canvas = render.gameObject;
        canvas.SetActive(false);
    }
    void OnTriggerEnter(Collider col)
    {
        canvas.SetActive(true);
        Instantiate(effect, fxspots[0].position, fxspots[0].rotation);
        Instantiate(effect, fxspots[0].position, fxspots[0].rotation);
        Invoke("ResetGame", 5f);



    }
        void ResetGame()
    {
        //DestroyImmediate(effect, true);
        canvas.SetActive(false);
        player.Reset();
    }


}
