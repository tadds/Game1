using UnityEngine;
using System.Collections;

public class SetSize : MonoBehaviour {
    public GameObject Box;
    // Use this for initialization
    void Start () {
        Box.GetComponent < RectTransform >().localScale = new Vector3(.9f,.9f,1f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
