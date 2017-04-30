using UnityEngine;
using System.Collections;

public class MoveMyCube : MonoBehaviour {
	float speed = 10f;
	Transform t;



	void Awake()
	{
		t = transform;
	}



	void Update () {
		Vector3 pos = t.position;

		pos += new Vector3( Input.GetAxis("Horizontal"),
							0,
							Input.GetAxis("Vertical"))
				* speed  * Time.deltaTime;

		t.position = pos;
	}
}
