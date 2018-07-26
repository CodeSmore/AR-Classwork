using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyBallBehavior : MonoBehaviour {

    public float spd = 30;
    public float increaseRate = 0.20f;
    private int xDirection = 1, zDirection = 1;

	// Use this for initialization
	void Start () {
        Move();
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void Move()
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(spd * xDirection, 0, spd * zDirection);
    }

    void ChangeDirection(int xChange, int zChange)
    {
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(spd * xChange * (1 + increaseRate), 0, spd * zChange * (1 + increaseRate));
    }

    void OnCollisionEnter(Collision collision)
    {
        // On collision with wall, reverse x or y velocity based on which boundary hit
        // On collision with ball, increase speed by 10% and add ball to scene

        if (collision.gameObject.name == "Front")
        {
            ChangeDirection(-1, 1);
        }
        else if (collision.gameObject.name == "Left")
        {
            ChangeDirection(1, -1);
        }
        else if (collision.gameObject.name == "Back")
        {
            ChangeDirection(-1, 1);
        }
        else if (collision.gameObject.name == "Right")
        {
            ChangeDirection(1, -1);
        }
        else if (collision.gameObject.tag == "CrazyBall")
        {
            // create ball
        }
        
    }
    
}
