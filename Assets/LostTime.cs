using UnityEngine;
using System.Collections;

using System;
using UnityEngine.UI;

public class LostTime : MonoBehaviour {


    public GameObject LostTimeup;
    public GameObject Lost;
    public float time;
    static public int Couter;

    // Use this for initialization
    void Start()
    {
        time = 0;
        Couter = 60;

    }



    
    void Update()
    {
        time = time + Time.deltaTime;
        if(Couter == 0)
        {
            LostTimeup.SetActive(true);
        }
        else if (Lost.active == true)
        {
           
            
        }
        else if (time > 1)
        {
            Couter = Couter - 1;
            time= 0;
            
        }
        
        else
        {

        }

    }
}
