using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1 = 0;
	public int scorePlayer2 = 0;
	public int limitScore = 3;

	public TextMeshProUGUI scorePlayer1Text;
	public TextMeshProUGUI scorePlayer2Text;
	public TextMeshProUGUI gameoverText;
	public TextMeshProUGUI winText;
	public Button retryButton;
	private SpawnManager spawnManager;
	public GameObject game;
	public GameObject scores;
	public GameObject menuGame;
	public GameObject iAPlayer;
	private IAController iAController;
	private BallMovement ballMovement;


	private void Start()
	{
		spawnManager = GameObject.Find(nameof(SpawnManager)).GetComponent<SpawnManager>();
		ballMovement = spawnManager.balPrefab.GetComponent<BallMovement>();
		iAController = iAPlayer.GetComponent<IAController>();

	}

	public void IncrementScorePlayer1()
	{
		scorePlayer1++;
		scorePlayer1Text.text = scorePlayer1.ToString();
	}

	public void IncrementScorePlayer2() 
	{
		scorePlayer2++;
		scorePlayer2Text.text = scorePlayer2.ToString();
	}

	private void StartPlay()
	{
		menuGame.SetActive(false);
		game.SetActive(true);
		scores.SetActive(true);
		spawnManager.CreateBall();
	}

	

	public void SetEasy()
	{
		iAController.speed = 5;
		ballMovement.speed = 10;
		StartPlay();
	}

	public void SetMedium()
	{
		iAController.speed = 8;
		ballMovement.speed = 12;
		StartPlay();
	}

	public void SetHard()
	{
		iAController.speed = 12;
		ballMovement.speed = 16;
		StartPlay();
	}

	private void Update()
	{
		SetGameoverScreen();

		SetWinScreen();
	}

	private void SetGameoverScreen()
	{
		if (IsGameOver())
		{
			game.SetActive(false);
			gameoverText.gameObject.SetActive(true);
			retryButton.gameObject.SetActive(true);
		}
	}

	private void SetWinScreen()
	{
		if (IsWin())
		{
			game.SetActive(false);
			winText.gameObject.SetActive(true);
			retryButton.gameObject.SetActive(true);
		}
	}

	public bool IsGameOver()
	{
		return scorePlayer2 >= limitScore;
	}

	public bool IsWin()
	{
		return scorePlayer1 >= limitScore;
	}

	public void Retry()
	{
		SceneManager.LoadScene(0);
	}
}
