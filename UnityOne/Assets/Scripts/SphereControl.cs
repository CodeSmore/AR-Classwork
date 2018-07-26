using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour {

    Vector3 rotationSpeed;

	// Use this for initialization
	void Start () {
        rotationSpeed = new Vector3(100, 50, 150);
	}
	
	// Update is called once per frame
	void Update () {
        Spin();
	}

    void Spin()
    {
        gameObject.transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
