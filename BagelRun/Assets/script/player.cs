﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

	private Rigidbody2D _rigid;

	// Use this for initialization
	void Start () {
		_rigid = this.GetComponent<Rigidbody2D> (); 
	}

	// Update is called once per frame
	void Update () {
		

		if (this.gameObject.transform.position.x < -10 && PlayerPrefs.GetInt ("isGameOver") == 0) {

			this.gameObject.transform.Rotate (0, 0, 0);
			PlayerPrefs.SetInt ("isGameOver", 1);

		} else if (this.gameObject.transform.position.x > -10) {
			this.gameObject.transform.Rotate (0, 0, -5);


		}

		if (SceneManager.GetActiveScene ().name == "SelectScene") {
			this.transform.Rotate (0, 0, -0.1f);
		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "stage") {
			PlayerPrefs.SetInt ("jumpping", 1);
		}
	}
}