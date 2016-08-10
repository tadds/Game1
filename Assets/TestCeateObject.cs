using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestCeateObject : MonoBehaviour {

    public GameObject original ;
    public GameObject[] parent ;
    Text MaxBox;

    void Start()

    {
        original = UnityEngine.GameObject.Find("1");
        parent = GameObject.FindGameObjectsWithTag("parent");
        MaxBox = UnityEngine.GameObject.Find("MaxBox").GetComponent<Text>();
        

        for (int i= 0; i< int.Parse(MaxBox.text); i++)
        {
            
            GameObject initialTransformGO = Instantiate(original) as GameObject;
            initialTransformGO.transform.parent = parent[0].transform;
            initialTransformGO.tag = "Box";
        }


         parent[0].AddComponent<RandomColor>() ;

    }

  

}
