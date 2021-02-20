using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDontReload : MonoBehaviour
{
    private static AudioDontReload instance = null;
    public static AudioDontReload Instance
	{
		get { return instance; }
	}

	private void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}

		DontDestroyOnLoad(this.gameObject);
	}
}
