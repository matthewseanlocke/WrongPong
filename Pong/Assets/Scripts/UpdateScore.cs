using UnityEngine;
using System.Collections;
using UnityEngine.UI; // we can write code for the canvas... the score text

public class UpdateScore : MonoBehaviour
{
    //public Transform target;

    //public GameObject RacketRight;

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
        // Note: 'col' holds the collision information. 
        // Did any Ball hit the Racket?
        if (col.gameObject)
        {
            // UPDATE SCORE
            scoreCount = scoreCount+1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        scoreText.text = "" + scoreCount.ToString();
    }

}