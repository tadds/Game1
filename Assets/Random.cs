using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Random : MonoBehaviour {
    public GameObject[] Stage;
    public Text ColorTrue;
   public Text MaxBox;
   
    int random;
    // Use this for initialization
    void Start () {
        Text Level = UnityEngine.GameObject.Find("Level").GetComponent<Text>();

        if (Int32.Parse(Level.text) == 1)
        {
            random = UnityEngine.Random.Range(1, 5);
            MaxBox.text ="4";
            Stage[0].SetActive(true);
        }
        else if(Int32.Parse(Level.text) == 2)
        {
            random = UnityEngine.Random.Range(1, 10);
            MaxBox.text = "9";
            Stage[1].SetActive(true);
        }
        else if (Int32.Parse(Level.text) < 5)
        {
            random = UnityEngine.Random.Range(1, 17);
            MaxBox.text = "16";
            Stage[2].SetActive(true);
        }
        else if (Int32.Parse(Level.text) < 9)
        {
            random = UnityEngine.Random.Range(1, 26);
            MaxBox.text = "25";
            Stage[3].SetActive(true);
        }
        else if (Int32.Parse(Level.text) < 15)
        {
            random = UnityEngine.Random.Range(1, 37);
            MaxBox.text = "36";
            Stage[4].SetActive(true);
        }
        else if (Int32.Parse(Level.text) < 19)
        {
            random = UnityEngine.Random.Range(1, 50);
            MaxBox.text = "49";
            Stage[5].SetActive(true);
        }
        else if (Int32.Parse(Level.text) < 25)
        {
            random = UnityEngine.Random.Range(1, 65);
            MaxBox.text = "64";
            Stage[6].SetActive(true);
        }
        else if (Int32.Parse(Level.text) < 29)
        {
            random = UnityEngine.Random.Range(1, 82);
            MaxBox.text = "81";
            Stage[7].SetActive(true);
        }
        else 
        {
            random = UnityEngine.Random.Range(1, 101);
            MaxBox.text = "100";
            Stage[8].SetActive(true);
        }

    }


    

    // Update is called once per frame
    void Update () {
        ColorTrue.text = random.ToString();
    }
}
