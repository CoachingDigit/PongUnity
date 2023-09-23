using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject balPrefab;

	public void CreateBall()
	{
		Instantiate(balPrefab, balPrefab.transform.position, balPrefab.transform.rotation);
	}

	
}
