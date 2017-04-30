using UnityEngine;
using System.Collections;

namespace BurgZergArcade.MecanimExamples
{
	[RequireComponent(typeof(Animator))]
	public class Movement : MonoBehaviour {
		Animator anim;



		void Awake() {
			anim = GetComponent<Animator>();
		}



		void Update() {
			anim.SetFloat("FSpeed", Input.GetAxis("Vertical"));
			anim.SetFloat("SSpeed", Input.GetAxis("Horizontal"));

			if(Input.GetKeyDown(KeyCode.Space))
				anim.SetTrigger("JumpAttack");
		}

	}
}
