using UnityEngine;
using System.Collections;

public class BackToStartScreenMikonipi : MonoBehaviour {
		TouchButton tb;
		public GameObject obj_tb;
	// Use this for initialization
	void Start () {
				tb = obj_tb.GetComponent<TouchButton> ();
	}
	
	// Update is called once per frame
	void Update () {
				if (tb._buttonEnabled == true) {
						Application.LoadLevel ("StartScen");
				}
	}
}
