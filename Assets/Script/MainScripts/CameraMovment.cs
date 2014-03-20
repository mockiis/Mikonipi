using UnityEngine;
using System.Collections;

public class CameraMovment : MonoBehaviour {
		public float cameraspeed = 0.2f;
		public bool reset = false;
		public bool movment = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

				if (reset == true) 
				{
						movment = false;
						Vector3 newposition = transform.position;
						newposition.y = 1;
						newposition.z = -10;
						newposition.x = 0;
						gameObject.transform.position = newposition;
						reset = false;
				}
				if (movment == true) {
						transform.position += transform.right * cameraspeed;
				}

	}
}
