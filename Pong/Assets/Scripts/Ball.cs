using UnityEngine;
using System.Collections;
using UnityEngine.UI; // we can write code for the canvas... the score text
//using TMPro; 

public class Ball : MonoBehaviour
{
    public float maxSpeed = 200;
    public float speed = 120;
    public AudioClip saw;

    public Transform target;

    public int scoreCount;
    public Text scoreText;

    void Start()
    {
        // Start Count
        scoreCount = 0;
        SetCountText();

        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;


        // is this how to start towards a target?
        //float step = speed * Time.deltaTime;
        //transform.position = Vector2.MoveTowards(transform.position, target.position, step);
        
        Screen.orientation = ScreenOrientation.Portrait;

        //scoreCount = 0;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                    float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket

        return (ballPos.y - racketPos.y) / racketHeight;
        
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        // Note: 'col' holds the collision information. If the
        // Ball collided with a racket, then:
        //   col.gameObject is the racket
        //   col.transform.position is the racket's position
        //   col.collider is the racket's collider

        
        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Play sound
            GetComponent<AudioSource>().Play();

            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;

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