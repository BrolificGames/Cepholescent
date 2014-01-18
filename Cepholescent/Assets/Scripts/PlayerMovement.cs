using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float maxSpeed = 10f;
	private bool facingRight = true;

	void Start() {}

	void FixedUpdate() 
	{
		float move = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);

		if (move > 0 && !facingRight) Flip ();
		else if (move < 0 && facingRight) Flip ();
	}

	private void Flip()
	{
		facingRight = !facingRight;
		Vector3 updatedPlayerScale = transform.localScale;
		updatedPlayerScale.x *= -1;
		transform.localScale = updatedPlayerScale;
	}
}
