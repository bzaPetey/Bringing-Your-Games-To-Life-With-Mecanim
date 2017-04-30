using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
public class MoveByCurves : MonoBehaviour {
	Animator anim;



	void Awake()
	{
		anim = GetComponent<Animator>();
	}



	void Update ()
	{
		anim.SetFloat("x", Input.GetAxis("Horizontal"));
		anim.SetFloat("z", Input.GetAxis("Vertical"));
	}
}
