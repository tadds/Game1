using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class LostTimeCT : MonoBehaviour {
    public Text TimeCounter;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        TimeCounter.text = LostTime.Couter.ToString();

    }
}
