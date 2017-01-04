using UnityEngine;
using System.Collections;

public class Player1Controller : MonoBehaviour {

	CharacterController controller;

	Vector3 moveDirection;

	public float gravity;
	public float speedJump;
	public float speedX;


	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();

	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetAxis ("Horizontal")>0.0f) {
			moveDirection.x = Input.GetAxis ("Horizontal") * speedX;
		}

		if (Input.GetAxis ("Horizontal")<0.0f) {
			moveDirection.x = Input.GetAxis ("Horizontal") * speedX;
		}

		if (controller.isGrounded) {
			if(Input.GetButton("Jump"))
			{
				moveDirection.y = speedJump;

			}
		}


		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);
	}
}
