using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
public class Projectile : MonoBehaviour {
	float lifeTime = 2f;
	float speed = 10f;
	Transform t;



	void Awake()
	{
		t = transform;
	}



	void Start()
	{
		Invoke("DieHorribly", lifeTime);
	}



	void Update()
	{
		Vector3 pos = t.position;

		pos += t.forward * speed * Time.deltaTime;

		t.position = pos;
	}



	void DieHorribly()
	{
		Destroy(gameObject);
	}

}
