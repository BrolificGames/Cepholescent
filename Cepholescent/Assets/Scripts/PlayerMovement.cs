using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float maxSpeed = 10f;
	public Transform groundCheck;
	public LayerMask groundLayerMask;
	public float jumpForce = 30f;

	private bool facingRight = true;
	private bool grounded = false;
	private float groundRadius = 0.2f;
	private Animator animator;

	void Start() 
	{
		animator = GetComponent<Animator>();
	}

	void FixedUpdate() 
	{
		CheckIfGrounded();

		float move = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
		animator.SetFloat("Speed", Mathf.Abs(move));

		if (move > 0 && !facingRight) Flip ();
		else if (move < 0 && facingRight) Flip ();
	}

	void Update()
	{
		if (grounded && (Input.GetAxis("Jump") > 0))
		{
			animator.SetBool("Ground", false);
			rigidbody2D.AddForce(new Vector2(0, jumpForce));
		}
	}

	private bool CheckIfGrounded()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayerMask);
		animator.SetBool("Ground", grounded);

		animator.SetFloat("VerticalSpeed", rigidbody2D.velocity.y);
		return !grounded;
	}

	private void Flip()
	{
		facingRight = !facingRight;
		Vector3 updatedPlayerScale = transform.localScale;
		updatedPlayerScale.x *= -1;
		transform.localScale = updatedPlayerScale;
	}
}
