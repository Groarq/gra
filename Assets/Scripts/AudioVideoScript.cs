﻿using UnityEngine;
using System.Collections;

public class AudioVideoScript : MonoBehaviour {

	public Camera gameCamera;
	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("Game Volume"))
		 {
			AudioListener.volume = PlayerPrefs.GetFloat("Game Volume");
		 }
		if(PlayerPrefs.HasKey("Game FOV"))
		   {
			gameCamera.fieldOfView = PlayerPrefs.GetFloat("Game FOV");
		}

	
	}
	

}
