using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
public class VampWithAGun : MonoBehaviour {
	Animator anim;



	void Awake()
	{
		anim = GetComponent<Animator>();
	}



	void Update()
	{
		SetLayerWeight();
		MoveMe();
	}



	void MoveMe()
	{
		anim.SetFloat("Forward", Input.GetAxis("Vertical"));
	}



	void SetLayerWeight()
	{
		//change to no gun layer
		if(Input.GetKeyDown(KeyCode.Alpha1))
		{
			Debug.Log("No Gun");
			anim.SetLayerWeight(1, 0);
		}

		//change to gun layer
		if(Input.GetKeyDown(KeyCode.Alpha2))
		{
			Debug.Log("Gun");
			anim.SetLayerWeight(1, 1);
		}
	}
}
