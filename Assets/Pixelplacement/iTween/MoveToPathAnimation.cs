using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPathAnimation : MonoBehaviour {

	public float time = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		iTween.MoveTo (gameObject, iTween.Hash("path", new Vector3[]{new Vector3(15,200,3), new Vector3(2,15,3), new Vector3(3,2,15)}, "time", time));

	}
}
