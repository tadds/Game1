﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class score : MonoBehaviour {
    Text Level ;
    public Text Score;
    // Use this for initialization
    void Start () {
        Level = UnityEngine.GameObject.Find("Level").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        Score.text = " Score  : " + Level.text;

    }

    public void ONClick()
    {
        Application.LoadLevel("game");
        Level.text = "1";
       // Lost.SetActive(false);
    }
}
