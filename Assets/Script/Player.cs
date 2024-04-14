using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float movePower = 1f;
	Rigidbody2D rigid;
	SpriteRenderer Renderer;

	void Start()
	{
		rigid = gameObject.GetComponent<Rigidbody2D>();
		Renderer = gameObject.GetComponent<SpriteRenderer>();
	}

	void Update()
	{
	}

	void FixedUpdate()
	{
		Move();
	}

	void Move()
	{
		Vector3 moveVelocity = Vector3.zero;

		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			Renderer.flipX = true;
			moveVelocity += Vector3.left;
		}

		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			Renderer.flipX = false;
			moveVelocity += Vector3.right;
		}

		if (Input.GetAxisRaw("Vertical") > 0)
		{
			moveVelocity += Vector3.up;
		}

		if (Input.GetAxisRaw("Vertical") < 0)
		{
			moveVelocity += Vector3.down;
		}

		rigid.velocity = moveVelocity * movePower * Time.deltaTime;
	}

}