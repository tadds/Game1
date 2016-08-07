using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class SetStage1 : MonoBehaviour {
    Text MaxBox;
    public GameObject[] parent;
    // Use this for initialization
    void Start () {
        parent = GameObject.FindGameObjectsWithTag("parent");
        MaxBox = UnityEngine.GameObject.Find("MaxBox").GetComponent<Text>();

        if(MaxBox.text =="4")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize= new Vector2(50f, 50f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 2;
        }
        else if (MaxBox.text == "9")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(33f, 33f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 3;
        }
        else if (MaxBox.text == "16")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(25f, 25f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 4;
        }
        else if (MaxBox.text == "25")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(20f, 20f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 5;
        }
        else if (MaxBox.text == "36")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(16.55f, 16.55f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 6;
        }
        else if (MaxBox.text == "49")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(14.3f, 14.3f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 7;
        }
        else if (MaxBox.text == "64")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(12.5f, 12.5f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 8;
        }
        else if (MaxBox.text == "99")
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(11.1f, 11.1f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 9;
        }
        else
        {
            parent[0].GetComponent<GridLayoutGroup>().cellSize = new Vector2(10f, 10f);
            parent[0].GetComponent<GridLayoutGroup>().constraintCount = 10;
        }



    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
