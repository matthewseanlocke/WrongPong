using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour {

    public Transform[] SpawnPoints;
    public float spawnTime = 1.5f;
    //public float speed = 120;

    //do we need initial speed? --> nope
    // public float speed = 120;

    //public GameObject Sperm;
    public GameObject[] Sperm;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("SpawnSperm", spawnTime, spawnTime);

        // Do we need initial Velocity --> nope
        //GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
    }

    // Update is called once per frame
    void Update () {
		
	}

    void SpawnSperm ()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length); // set the index number of the array randomly

        int ObjectIndex = Random.Range(0, Sperm.Length);

        Instantiate(Sperm[ObjectIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);



    }
}
