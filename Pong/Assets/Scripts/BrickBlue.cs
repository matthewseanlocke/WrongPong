using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlue : MonoBehaviour
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
        if ((col.gameObject.name == "Ball") || (col.gameObject.name == "RedSperm") || (col.gameObject.name == "Ball (1)") || (col.gameObject.name == "Ball (2)") || (col.gameObject.name == "Ball(Clone)"))
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject, 0.25f);
                      
        }
    }
}

