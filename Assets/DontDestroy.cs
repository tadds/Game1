using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Application.LoadLevel("game");
    }

    public void OnClick2()
    {
        Application.LoadLevel("game2");
    }
}
