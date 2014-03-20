using UnityEngine;
using System.Collections;

public class MoveCameratoSelectedPlace : MonoBehaviour {

		MouseManager mousemanager;
		Transform target;
		public Transform obj_MouseManager;
		float smooth  = 2.0f;
	void Start () {
				mousemanager = obj_MouseManager.GetComponent<MouseManager> ();
	}
	
	// Update is called once per frame
	void Update () {
				if (mousemanager.scenSelect == 1) {
						gameObject.transform.position = new Vector3 (0, 0, -10);
						//gameObject.transform.Rotate = new Vector3 (0, 0, 0);
						gameObject.transform.localScale = new Vector3 (1, 1, 1);
					
				}
				if (mousemanager.scenSelect == 2) {

				}
				if (mousemanager.scenSelect == 3) {

				}
	}
}
