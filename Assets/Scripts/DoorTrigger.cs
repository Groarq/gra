﻿using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
	private bool param=false;
	private bool doorIsOpen=false;
	public int speedOpen=100;
	private bool firstOpen=true;
	private bool firstClose=true;
	public AudioClip doorSound;
	void Update(){
		if (Input.GetKey(KeyCode.E) && param==true) {
			if(transform.FindChild("body").localEulerAngles.y < 90.0f){
				if(firstOpen){
					firstClose=true;
					audio.PlayOneShot(doorSound);
					firstOpen=false;
				}
				transform.FindChild("body").Rotate(Vector3.up*0.04f*speedOpen);
			}
		}
		if(doorIsOpen){
			if(transform.FindChild("body").localEulerAngles.y > 2){
				if(firstClose){
					firstOpen=true;
					audio.PlayOneShot(doorSound);
					firstClose=false;
				}
				transform.FindChild("body").Rotate(Vector3.down*0.02f*speedOpen);
			}
			else{
				doorIsOpen=false;
			}
		}
	}
	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag=="Player"){
			param=true;
		}
	}
	void OnTriggerExit(){
		doorIsOpen = true;
		param = false;
	}
}
