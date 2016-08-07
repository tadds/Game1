using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestCeateObject : MonoBehaviour {

    public GameObject[] original ;
    public GameObject[] parent ;
    Text MaxBox;

    void Start()

    {
        original = GameObject.FindGameObjectsWithTag("Box");
        parent = GameObject.FindGameObjectsWithTag("parent");
        MaxBox = UnityEngine.GameObject.Find("MaxBox").GetComponent<Text>();
        

        for (int i= 0; i< int.Parse(MaxBox.text)-1; i++)
        {
            
            GameObject initialTransformGO = Instantiate(original[0]) as GameObject;
            initialTransformGO.transform.parent = parent[0].transform;
        }


        RandomColor2 sc = parent[0].AddComponent<RandomColor2>() as RandomColor2;

    }

    // Update is called once per frame
    void Update () {
	
	}

    void CeateObject ()
    {

    }

}
