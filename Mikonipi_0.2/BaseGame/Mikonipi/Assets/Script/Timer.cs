using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
		public Vector3 time;
		public bool timesUp = false;
		public bool startTimer = false;
		public bool reset = false;
	// Use this for initialization
	void Start () {
				gameObject.transform.localScale = new Vector3 (time.x, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
				if (time.x > -0.01f && startTimer == true) {
						time.x -= Time.deltaTime / 10;
						gameObject.transform.localScale = new Vector3 (time.x, 0, 0);
					
				}
				if( time.x< -0.01f && startTimer == true) {
						timesUp = true;
						startTimer = false;


				}
				if (reset == true) {
						time.x = 1f;
						gameObject.transform.localScale = new Vector3 (time.x, 0, 0);
						timesUp = false;
						startTimer = false;
						reset = false;
				}

	}
}
