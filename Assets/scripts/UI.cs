using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private Text textComponent;
    private int score = 0;
    public Collider col;
    

    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.text = "Score:"+score.ToString();
        
    }

    public void increaseScore()
    {
        score++;
    }

    public void decreaseScore()
    {
        score--;
    }
}
