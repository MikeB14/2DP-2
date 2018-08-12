using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towers : MonoBehaviour {

    public int SpawnTimer = 0;
    public int Lives = 5;
    private int RandSpark;
    private int RandSparkPoint;
    public Transform[] Sparks;
    public Transform[] Sparkpoints;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SpawnTimer++;
        RandSpark = Random.Range(0, 7);
        RandSparkPoint = Random.Range(0, 10);
		if(Lives <= 0)
        {
            Debug.Log("Tower Down!");
        }

        if(SpawnTimer >= 200)
        {
            Instantiate(Sparks[RandSpark], Sparkpoints[RandSparkPoint].position, Sparkpoints[RandSparkPoint].rotation);
            SpawnTimer = 0;
        }
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bad")
        {
            Lives = Lives - 1;
        }
    }
}
