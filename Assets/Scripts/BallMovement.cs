using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
	public float speed;
	Vector2 direction;


	Rigidbody2D rb;
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		direction = Vector2.one.normalized;
	}

	private void FixedUpdate()
	{
		rb.velocity = direction * speed;
	}
	// Update is called once per frame
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Wall"))
		{
			direction.y = -direction.y;
		}
		else if (collision.gameObject.CompareTag("Player"))
		{
			direction.x = -direction.x;

		}
	}
}
