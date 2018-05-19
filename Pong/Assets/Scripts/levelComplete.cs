using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelComplete : MonoBehaviour
{

    //FUCK THIS CODE, it wasn't working the way I wanted. Not for collision, for Trigger.
    //void OnTriggerEnter2D(Collider2D co)
    //{
    //    if (co.name == "Ball")
    //        Destroy(gameObject, 0.25f);

    //    GetComponent<AudioSource>().Play();
    //}

    void OnCollisionEnter2D(Collision2D col)
    {
        if ((col.gameObject.name == "Ball") || (col.gameObject.name == "Ball1") || (col.gameObject.name == "Ball2") || (col.gameObject.name == "Ball3") || (col.gameObject.name == "Ball4") || (col.gameObject.name == "Ball5") || (col.gameObject.name == "Ball6") || (col.gameObject.name == "Ball7") || (col.gameObject.name == "Ball8") || (col.gameObject.name == "Ball9") || (col.gameObject.name == "Ball10"))
        {
            Debug.Log("Level Over");

        }
    }
}

