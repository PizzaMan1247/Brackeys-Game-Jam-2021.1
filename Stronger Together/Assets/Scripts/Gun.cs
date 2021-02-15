using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource m_shootingAudio;

	private void Start()
	{
		m_shootingAudio = GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (Input.GetMouseButton(0))
		{
			m_shootingAudio.Play();
		}
	}
}
