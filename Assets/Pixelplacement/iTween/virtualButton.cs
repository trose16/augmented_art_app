using UnityEngine;
using System.Collections;
using Vuforia;

public class  virtualButton : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vbButtonObject;
	private GameObject image_target;
	public bool includechildren = true;
	// Use this for initialization
	void Start () {

		vbButtonObject = GameObject.Find ("virtualButton");
		image_target = GameObject.Find ("lg_triangle_3d");
		vbButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);

	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {


		Debug.Log("button down!!!");
		image_target.GetComponent<Animation> ().Play ();

	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {

		image_target.GetComponent<Animation> ().Stop ();

	}
}
