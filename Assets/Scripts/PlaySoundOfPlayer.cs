using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOfPlayer : MonoBehaviour
{
    private AudioSource playerSound;
    void Start()
    {
        playerSound = GetComponent<AudioSource>();
    }

	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.CompareTag("Bal"))
        {
            playerSound.Play();
        }
	}
}
