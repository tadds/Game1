using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ClickCheck2 : MonoBehaviour {

    public Text AColorTrue;
    //public Text Level;
    Text Level;
    public GameObject Lost;
    // public GameObject[] Lost2;
    void Start()
    {

        Level = UnityEngine.GameObject.Find("Level").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void ONClickcheck()
    {
        int nextLevel = int.Parse(Level.text) + 1;
        if (GetComponent<Image>().color.a == float.Parse(AColorTrue.text))
        {
            Debug.Log("win");
            RemoveBox.Destory();
            Level.text = nextLevel.ToString();
        }
        else
        {
            /*
            Debug.Log("lost");
            Lost.SetActive(true);*/
        }
    }
}
