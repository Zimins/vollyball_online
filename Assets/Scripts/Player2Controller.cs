using UnityEngine;
using System.Collections;

public class Player2Controller : MonoBehaviour {


	CharacterController controller;
	Animator anim;

	Vector3 moveDirection;

	public float gravity;
	public float speedJump;
	public float speedX;
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.D)) {
			moveDirection.z = Input.GetAxis ("Horizontal") * speedX;
			anim.SetBool ("Walk Forward",true);
		} else if (Input.GetKey (KeyCode.A)) {
			moveDirection.z = Input.GetAxis ("Horizontal") * speedX;
			anim.SetBool ("Walk Backward",true);
		} else {
			moveDirection.z = 0;
			anim.SetBool("Walk Forward",false);
			anim.SetBool ("Walk Backward",false);
		}

		if (controller.isGrounded) {


			if(Input.GetKey(KeyCode.W))
			{
				moveDirection.y = speedJump;

			}
		}


		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);
	
	}

	void Animating(float x)
	{
		
	}
}
