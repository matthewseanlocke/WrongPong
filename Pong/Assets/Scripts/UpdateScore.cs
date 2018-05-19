using UnityEngine;
using System.Collections;
using UnityEngine.UI; // we can write code for the canvas... the score text
//using TMPro; 

public class UpdateScore : MonoBehaviour
{


    public int scoreCount;
    public Text scoreText;

    void Start()
    {
        // Start Count
        scoreCount = 0;
        SetCountText();

    }


    void OnCollisionEnter2D(Collision2D col)
    {
        // Hit the right Racket?
        if (col.gameObject)
        {
            // UPDATE SCORE
            scoreCount = scoreCount + 1;
            SetCountText();

        }
    }

    void SetCountText()
    {
        scoreText.text = "" + scoreCount.ToString();
    }

}