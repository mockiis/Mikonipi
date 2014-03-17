using UnityEngine;
using System.Collections;

public class PlayerMovment2 : MonoBehaviour {
		public TouchButtonRight tbu;
		public Transform obj_tbu;

		public TouchButton tbd;
		public Transform obj_tbd;

		public CameraMovment cMovement;
		public Transform obj_camera;

		public bool movement=false;
		public bool reset =false;

		public float playerSpeed = 0.1f;
		public Rigidbody2D ridigbody2d;

	// Use this for initialization
	void Start () {
				tbu = obj_tbu.GetComponent<TouchButtonRight> ();
				tbd = obj_tbd.GetComponent<TouchButton> ();
				cMovement = obj_camera.GetComponent<CameraMovment> ();
				ridigbody2d = gameObject.GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
	
				if (tbu._buttonEnabled == true) {
						Debug.Log ("Up");
						Vector3 newposition = transform.position;
						newposition.y += 0.1f;

						gameObject.transform.position = newposition;
				}
				if (tbd._buttonEnabled == true) {
						Debug.Log ("Down");
						Vector3 newposition = transform.position;
						newposition.y -= 0.1f;

						gameObject.transform.position = newposition;

				}
				if (Input.GetButton ("Fire1")) {

						movement = true;
						cMovement.movment = true;

				}

				if (reset == true) 
				{
						movement = false;
						cMovement.reset = true;
						Vector3 newposition = transform.position;
						newposition.y = 3;
						newposition.x = -2;
						gameObject.transform.position = newposition;

						reset = false;
				}
				if (movement == true) 
				{
						transform.position += transform.right * playerSpeed;
				}

	}
}
