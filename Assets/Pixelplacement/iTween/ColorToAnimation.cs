using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorToAnimation : MonoBehaviour {

	public Color color = new Color();
	public float time = 3;
	public float delay = 3;
	public string loopType = "pingPong";
	public bool includechildren = true;


	// Use this for initialization
	void Start () {

		iTween.ColorTo(gameObject,iTween.Hash("color", color, "time", time, "delay", delay, "loopType", loopType, "includechildren", includechildren));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
