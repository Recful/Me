namespace MoenenGames.MPCCharacterDemo {
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;


	public class Player : MonoBehaviour {



		private void Update () {
			// Movement
			var rig = GetComponent<Rigidbody2D>();
			if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
				rig.velocity = Vector2.left * 5f;
				transform.localScale = new Vector3(-1f, 1f, 1f);
			} else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
				rig.velocity = Vector2.right * 5f;
				transform.localScale = new Vector3(1f, 1f, 1f);
			} else {
				rig.velocity = Vector2.zero;
			}
			// Attack
			bool attackA = false;
			bool attackB = false;
			if (Input.GetKey(KeyCode.O) || Input.GetKey(KeyCode.Mouse0)) {
				attackA = true;
				attackB = false;
			}
			if (Input.GetKey(KeyCode.P) || Input.GetKey(KeyCode.Mouse1)) {
				attackA = false;
				attackB = true;
			}
			// Animation
			Animator ani = GetComponentInChildren<Animator>(true);
			bool hasSpeed = false;
			bool hasAttackA = false;
			bool hasAttackB = false;
			for (int i = 0; i < ani.parameterCount; i++) {
				if (ani.parameters[i].name == "Speed") {
					hasSpeed = true;
				} else if (ani.parameters[i].name == "AttackA") {
					hasAttackA = true;
				} else if (ani.parameters[i].name == "AttackB") {
					hasAttackB = true;
				}
			}
			if (hasSpeed) {
				ani.SetFloat("Speed", Mathf.Abs(rig.velocity.x));
			}
			if (hasAttackA) {
				ani.SetBool("AttackA", attackA);
				if (attackA) {
					rig.velocity = Vector2.zero;
				}
			}
			if (hasAttackB) {
				ani.SetBool("AttackB", attackB);
				if (attackB) {
					rig.velocity = Vector2.zero;
				}
			}
		}

	}
}
