﻿using UnityEngine;
using System.Collections;

public class QuitGameClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void QuitGame()
    {
		System.Diagnostics.Process.GetCurrentProcess().Kill();
		//
        Application.Quit();
		//Test

    }
}
