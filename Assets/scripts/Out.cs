using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Out : MonoBehaviour
{
    public Man player;
    public Ball ball;
    public GameObject canvas;
    public UI Scoreboard;

    void Start()
    {
        canvas.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        canvas.SetActive(true);
        Invoke("ResetGame", 4f);
        Scoreboard.resetScore();
    }
    void ResetGame()
    {
        //DestroyImmediate(effect, true);
        canvas.SetActive(false);
        player.Reset();
        ball.Reset();


    }
}
