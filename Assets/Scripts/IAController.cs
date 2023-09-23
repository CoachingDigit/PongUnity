using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAController : MonoBehaviour
{
    public float speed = 5.0f;
    private GameObject ballInstance;
    void Start()
	{
		SetBalInstance();

	}

	private void SetBalInstance()
	{
		if (ballInstance == null)
		{
			ballInstance = GameObject.FindWithTag("Bal");

		}
	}

	// Update is called once per frame
	private void FixedUpdate()
	{
		SetBalInstance();

		if (ballInstance.transform.position.y > transform.position.y)
		{
			transform.Translate(Vector2.up * speed * Time.deltaTime);
		}
		else if (ballInstance.transform.position.y < transform.position.y)
		{
			transform.Translate(Vector2.down * speed * Time.deltaTime);
		}


	}
	
}
