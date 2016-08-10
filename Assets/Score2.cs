using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Score2 : MonoBehaviour {
    Text Level;
    public Text Score;
    public GameObject Lost;
    // Use this for initialization
    void Start()
    {
        Level = UnityEngine.GameObject.Find("Level").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = " Score  : " + Level.text;

    }

    public void ONClick()
    {
        Lost.SetActive(false);
        Level.text = "1";
        LostTime.Couter= 61;
        RemoveBox.Destory();
    }
}
