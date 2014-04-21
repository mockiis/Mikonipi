using UnityEngine;
using System.Collections;

public class BackToStartScreen : MonoBehaviour {
		public TouchButtonRight tbr;
		public Transform obj_button;
	// Use this for initialization
	void Start () {
				tbr = obj_button.GetComponent<TouchButtonRight> ();
	}
	
	// Update is called once per frame
	void Update () {
				if (tbr._buttonEnabled == true) {
						Application.LoadLevel ("StartScreen");
				}	
	}
}
