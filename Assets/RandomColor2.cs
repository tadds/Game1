using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class RandomColor2 : MonoBehaviour {

    public GameObject[] Box;
     Text ColorTrue;
     Text MaxBox;
     Text AColorTrue;



    Color a;
    Color c;
    // Use this for initialization
    void Start()
    {
        Box = GameObject.FindGameObjectsWithTag("Box");
        ColorTrue = UnityEngine.GameObject.Find("ColorTrue").GetComponent<Text>();
        MaxBox = UnityEngine.GameObject.Find("MaxBox").GetComponent<Text>();
        AColorTrue = UnityEngine.GameObject.Find("AColorTrue").GetComponent<Text>();

        a = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1f);


        c = new Color(a.r, a.g, a.b, .87f);




        AColorTrue.text = c.a.ToString();

    }

    void Update()
    {

        for (int i = 0; i < Int32.Parse(MaxBox.text); i++)
        {
            if (Int32.Parse(ColorTrue.text) == i + 1)
            {
                Box[i].GetComponent<Image>().color = c;
            }
            else
            {
                Box[i].GetComponent<Image>().color = a;
            }
        }
    }
}
