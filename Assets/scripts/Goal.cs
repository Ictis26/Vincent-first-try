using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Goal : MonoBehaviour
{
    public Man player;
    public Ball ball;
   
   

    private GameObject canvas;
    public GameObject effect;
    public Transform[] fxspots;
    public UI Scoreboard;

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
        Scoreboard.increaseScore();


    }
        void ResetGame()
    {
        //DestroyImmediate(effect, true);
        canvas.SetActive(false);
        player.Reset();
        ball.Reset();

       
    }


}
