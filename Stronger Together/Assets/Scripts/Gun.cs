using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource m_shootingAudio;

	private void OnMouseDown()
	{
		m_shootingAudio = GetComponent<AudioSource>();
	}
}
