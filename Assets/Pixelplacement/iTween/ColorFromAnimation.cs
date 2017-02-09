using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFromAnimation : MonoBehaviour {

	public float green = 2;
	public float red = 0;
	public float blue = 0;
	public float delay = 2;
	public string loopType = "pingPong";


	// Use this for initialization
	void Start () {

		iTween.ColorFrom (gameObject, iTween.Hash("g",green, "r", red, "b", blue, "delay", delay, "loopType",loopType));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
