using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class RemoveBox : MonoBehaviour {
    static public GameObject[] Box;
    static Text MaxBox;
    static public GameObject[] Stage;





    static public void Destory()
    {
        Stage = GameObject.FindGameObjectsWithTag("parent");
        Box = GameObject.FindGameObjectsWithTag("Box");
        MaxBox = UnityEngine.GameObject.Find("MaxBox").GetComponent<Text>();
        for (int i = 0; i < int.Parse(MaxBox.text); i++)
        {
            Destroy(Box[i]);
        }
        Destroy(Stage[0].GetComponent<TestCeateObject>());
        Destroy(Stage[0].GetComponent<SetStage1>());
        Destroy(Stage[0].GetComponent<RandomColor>());
        Random3.Randomnumber();
    }
}
