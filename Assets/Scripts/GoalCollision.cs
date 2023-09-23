using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour
{
	private GameManager gameManager;
	private SpawnManager spawnManager;
	private void Start()
	{
		gameManager = GameObject.Find(nameof(GameManager)).GetComponent<GameManager>();
		spawnManager = GameObject.Find(nameof(SpawnManager)).GetComponent<SpawnManager>();
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Bal"))
		{
			if(name == "Goal1")
			{
				gameManager.IncrementScorePlayer2();
			}
			else if (name == "Goal2")
			{
				gameManager.IncrementScorePlayer1();
			}
			Destroy(collision.gameObject);
			if(!gameManager.IsGameOver() && !gameManager.IsWin())
			{
				spawnManager.CreateBall();
			}
			

		}
	}
}
