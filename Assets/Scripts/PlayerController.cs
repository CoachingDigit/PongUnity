using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private float boundary = 3.0f;

	void Start()
    {
	}
	// Update is called once per frame
	void Update()
	{
		MovePlayer();

	}

	

	private void MovePlayer()
	{
		float verticalInput = Input.GetAxis("Vertical");
		Vector3 newPosition = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);

		newPosition.y = Mathf.Clamp(newPosition.y, -boundary, boundary);

		transform.position = newPosition;
	}

	
}
