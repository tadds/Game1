using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour {
    public Image[] Box;
    public Text ColorTrue;
    public Text MaxBox;
    public Text AColorTrue;

    

    Color a;
    Color c;
    // Use this for initialization
    void Start () {
           
        a = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1f);
        
        
            c = new Color(a.r , a.g, a.b, .87f);



       
         AColorTrue.text = c.a.ToString();

    }

    void Update()
    {
        
        for (int i = 0; i < Int32.Parse(MaxBox.text); i++)
        {
            if (Int32.Parse(ColorTrue.text) == i + 1)
            {
                Box[i].color = c;
            }
            else
            {
                Box[i].color = a;
            }
        }
    }

}
