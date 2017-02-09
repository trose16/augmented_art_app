using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ButtonAction : MonoBehaviour {

	public void GoIndex () {
		SceneManager.LoadScene ("Index");
	}

	public void GoHome () {
		SceneManager.LoadScene ("Home");
	}

	public void GoArtist () {
		SceneManager.LoadScene ("Artist");
	}

	public void GoCanvas () {
		SceneManager.LoadScene ("Canvas");
	}

	public void GoAugment () {
		SceneManager.LoadScene ("Augment");
	}
}
