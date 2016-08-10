using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Random3 : MonoBehaviour {

    static public Text ColorTrue;
    static public Text MaxBox;
    static public GameObject Stage;
    static public GameObject ST;
    public Text ColorTrue2;
    public Text MaxBox2;
    public GameObject Stage2;
    public GameObject ST2;
    public GameObject TimeCT;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        ST = ST2;
        Stage = Stage2;
        MaxBox = MaxBox2;
        ColorTrue = ColorTrue2;
    }

    public void Randomnumber2()
    {
        ST.SetActive(false);
        Randomnumber();
        TimeCT.SetActive(true);
    }



    static public void Randomnumber()
    {
        
        int random;
        Text Level = UnityEngine.GameObject.Find("Level").GetComponent<Text>();

        if (Int32.Parse(Level.text) == 1)
        {
            random = UnityEngine.Random.Range(1, 5);
            MaxBox.text = "4";
        }
        else if (Int32.Parse(Level.text) == 2)
        {
            random = UnityEngine.Random.Range(1, 10);
            MaxBox.text = "9";

        }
        else if (Int32.Parse(Level.text) < 5)
        {
            random = UnityEngine.Random.Range(1, 17);
            MaxBox.text = "16";

        }
        else if (Int32.Parse(Level.text) < 9)
        {
            random = UnityEngine.Random.Range(1, 26);
            MaxBox.text = "25";

        }
        else if (Int32.Parse(Level.text) < 15)
        {
            random = UnityEngine.Random.Range(1, 37);
            MaxBox.text = "36";

        }
        else if (Int32.Parse(Level.text) < 19)
        {
            random = UnityEngine.Random.Range(1, 50);
            MaxBox.text = "49";


        }
        else if (Int32.Parse(Level.text) < 25)
        {
            random = UnityEngine.Random.Range(1, 65);
            MaxBox.text = "64";


        }
        else if (Int32.Parse(Level.text) < 29)
        {
            random = UnityEngine.Random.Range(1, 82);
            MaxBox.text = "81";

        }
        else
        {
            random = UnityEngine.Random.Range(1, 101);
            MaxBox.text = "100";

        }
        Stage.AddComponent<TestCeateObject>();
        Stage.AddComponent<SetStage1>();
        ColorTrue.text = random.ToString();
        
    }
    
}
