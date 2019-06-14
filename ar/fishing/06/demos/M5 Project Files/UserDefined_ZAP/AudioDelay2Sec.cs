using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioDelay2Sec : MonoBehaviour {
	public  GameObject PlayerCamera;


	// Use this for initialization
	void Start ()

		{
		AudioListener.volume = 0f;
		StartCoroutine ("waitSeconds");
		}

		IEnumerator waitSeconds()
		{
		yield return new WaitForSeconds (2);
		print ("2 Seconds");
		AudioListener.volume = .5f;
		}
		

	// Update is called once per frame
	void Update () 
	{
		
	}
}
