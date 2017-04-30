using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
public class CubeDude : MonoBehaviour {
	public GameObject projectile;
	public Transform projectileLaunchPoint;

	Animator anim;



	void Awake()
	{
		anim = GetComponent<Animator>();
	}



	void Update()
	{
		anim.SetFloat("Move", Input.GetAxis("Horizontal"));

		if(Input.GetKeyDown(KeyCode.Alpha1))
			FireProjectile();
		
		if(Input.GetKeyDown(KeyCode.Space))
			anim.SetTrigger("360");
	}



	public void FireProjectile()
	{
		Instantiate(projectile, projectileLaunchPoint.position, transform.rotation);
	}
}
