using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class RandomColor3 : MonoBehaviour {
    public Image a1;
    public Image a2;
    public Image a3;
    public Image a4;
    public Image a5;
    public Image a6;
    public Image a7;
    public Image a8;
    public Image a9;
    public Image a10;
    public Image a11;
    public Image a12;
    public Image a13;
    public Image a14;
    public Image a15;
    public Image a16;
    public Text ColorTrue;
    public Text RColorTrue;
    public Text GColorTrue;
    public Text BColorTrue;


    Color a;
    Color c;
    // Use this for initialization
    void Start()
    {
        a = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);

        if (a.r > a.b && a.r > a.g)
        {
            c = new Color(a.r - 0.15f, a.g, a.b);
        }
        else if (a.b > a.r && a.b > a.g)
        {
            c = new Color(a.r, a.g, a.b - 0.15f);
        }
        else if (a.g > a.r && a.g > a.b)
        {
            c = new Color(a.r, a.g - 0.15f, a.b);
        }
        else
        {
            c = new Color(a.r, a.g - 0.15f, a.b);
        }





        RColorTrue.text = c.r.ToString();
        GColorTrue.text = c.g.ToString();
        BColorTrue.text = c.b.ToString();
    }

    void Update()
    {
        if (Int32.Parse(ColorTrue.text) == 1)
        {
            a1.color = c;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 2)
        {
            a1.color = a;
            a2.color = c;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 3)
        {
            a1.color = a;
            a2.color = a;
            a3.color = c;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 4)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = c;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 5)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = c;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 6)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = c;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 7)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = c;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 8)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = c;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 9)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = c;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 10)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = c;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 11)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = c;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 12)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = c;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 13)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = c;
            a14.color = a;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 14)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = c;
            a15.color = a;
            a16.color = a;
        }
        else if (Int32.Parse(ColorTrue.text) == 15)
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = c;
            a16.color = a;
        }
        else 
        {
            a1.color = a;
            a2.color = a;
            a3.color = a;
            a4.color = a;
            a5.color = a;
            a6.color = a;
            a7.color = a;
            a8.color = a;
            a9.color = a;
            a10.color = a;
            a11.color = a;
            a12.color = a;
            a13.color = a;
            a14.color = a;
            a15.color = a;
            a16.color = c;
        }

    }
}
