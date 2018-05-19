using UnityEngine;
using System.Collections;

public class MoveRacket : MonoBehaviour
{
    
    public float speed;

    //public float width = 1;
    //public float height = 2;

    //public Transform target;

    //public string axis = "Horizontal";
    public GameObject PRIZE;

    void FixedUpdate()
    {
        // KEYBOARD ***********************************************************************
        //float v = Input.GetAxisRaw(axis);
        //GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * speed;

        // TOUCH ***************************************************************************

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        // Get movement of the finger since last frame
        //Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

        // Move object across XYZ plane --> coordinates x=0,y=1,z=0
        //transform.Translate(0, touchDeltaPosition.y * speed, 0);

        //}
        // ***********************************************************************************

        // Accelorometer *********************************************************************
        //transform.Translate(Mathf.Sin(Input.acceleration.x)* speed, Mathf.Cos(Input.acceleration.x)* speed, 0);

        // Rotate
        //transform.RotateAround(PRIZE.transform.position, Vector3.forward, speed * Time.deltaTime);
        transform.RotateAround(PRIZE.transform.position, Vector3.forward, speed * Input.acceleration.x);
        // ***********************************************************************************

    }

}
