using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

		public PointManager pmScript;
		public Transform object_pm;

	// Use this for initialization
	void Start () {
				pmScript = object_pm.GetComponent<PointManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
		public void OnTriggerEnter2D(Collider2D other)
		{
				if (other.gameObject.tag != "player") {
						pmScript.point += 10;
						pmScript.collectedNumberofpoints++;
						GameObject.Destroy (gameObject);
				}
		}
}
