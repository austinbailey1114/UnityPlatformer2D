using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;             //Floating point variable to store the player's movement speed.

	private Rigidbody2D rigidBody;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void FixedUpdate()
	{
		//Store the current horizontal input in the float moveHorizontal.
		float h = Input.GetAxis ("Horizontal");
		Vector2 newDir = rigidBody.velocity;

		Debug.Log (h.ToString());
		//Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
		if (h > 0) {
			newDir.x = speed;
		} else if (h == 0) {
			newDir.x = 0;
		} else {
			newDir.x = -speed;
		}

		rigidBody.velocity = newDir;
	}
}