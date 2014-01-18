using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float maxSpeed = 10f;
	private bool facingRight = true;
	private Animator animator;

	void Start() 
	{
		animator = GetComponent<Animator>();
	}

	void FixedUpdate() 
	{
		float move = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
		animator.SetFloat("Speed", Mathf.Abs(move));

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
