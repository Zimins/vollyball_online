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
	
		if (Input.GetKey (KeyCode.RightArrow)) {
			moveDirection.x = Input.GetAxis ("Horizontal") * speedX;
		} else if (Input.GetKey (KeyCode.LeftArrow)) {
			moveDirection.x = Input.GetAxis ("Horizontal") * speedX;
		} else {
			moveDirection.x = 0;
		}



		if (controller.isGrounded) {
			if(Input.GetKey(KeyCode.UpArrow))
			{
				moveDirection.y = speedJump;

			}
		}



		moveDirection.y -= gravity * Time.deltaTime;

		Vector3 globalDirection = transform.TransformDirection (moveDirection);
		controller.Move (globalDirection * Time.deltaTime);
	}
}
