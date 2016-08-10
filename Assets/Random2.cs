using UnityEngine;
using System;
using UnityEngine.UI;
using System.Collections;

public class Random2 : MonoBehaviour {
    public Text ColorTrue;
    public Text MaxBox;
    public GameObject Stage;
    public GameObject ST;

    static public int random;
    // Use this for initialization
   /* static public void Randomnumber()
    {

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
        Stage.AddComponent<SetStage1>() ;
        ColorTrue.text = random.ToString();
        ST.SetActive(false);
    }
    */



    // Update is called once per frame
   void Update()
    {
        ColorTrue.text = random.ToString();
    }
}
