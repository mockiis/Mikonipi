using UnityEngine;
using System.Collections;

public class PointManager : MonoBehaviour {

	public int point = 0;
		public int numberofpoints=5;
		public int collectedNumberofpoints = 0;
		public bool levelDonePoint = false;

	void Start () {
	
	}
	

	void Update () {
				guiText.text = point.ToString ();
				if (Application.loadedLevelName == ("Scen5")) {
						if (collectedNumberofpoints == numberofpoints) {
								Application.LoadLevel ("Scen5");
						}
				}
				if (Application.loadedLevelName == ("Scen7")) {
						if (collectedNumberofpoints == numberofpoints) {
								levelDonePoint = true;
						}
				}
	}
		public void reset()
		{
				levelDonePoint = false;
		}
}
