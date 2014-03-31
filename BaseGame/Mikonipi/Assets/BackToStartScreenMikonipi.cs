using UnityEngine;
using System.Collections;

public class BackToStartScreenMikonipi : MonoBehaviour {
		TouchButton tb;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetMouseButtonDown (0)) {
						if (gameObject.guiTexture.GetScreenRect ().Contains (Input.mousePosition)) {
								Application.LoadLevel ("StartScen");
						}
				}

	}
}
