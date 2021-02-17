using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{

    private GameMaster gm;

	private void Start()
	{
		gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
		transform.position = gm.lastCheckPointPos;
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (GameObject.FindGameObjectWithTag("Enemy"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
