using UnityEngine;
using System.Collections;

public class ChangeScen : MonoBehaviour {
		public TouchButtonRight touchButtonRight;
		public TouchButtonRight touchButtonRight2;
		public TouchButtonRight touchButtonRight3;
		public TouchButtonRight touchButtonRight4;
		public TouchButtonRight touchButtonRight5;
		public Transform objtbr;
		public Transform objtbr2;
		public Transform objtbr3;
		public Transform objtbr4;
		public Transform objtbr5;


	// Use this for initialization
	void Start () {
				touchButtonRight = objtbr.GetComponent<TouchButtonRight> ();
				touchButtonRight2 = objtbr2.GetComponent<TouchButtonRight> ();
				touchButtonRight3 = objtbr3.GetComponent<TouchButtonRight> ();
				touchButtonRight4 = objtbr4.GetComponent<TouchButtonRight> ();
				touchButtonRight5 = objtbr5.GetComponent<TouchButtonRight> ();
		}
	
	// Update is called once per frame
	void Update () {

				if (touchButtonRight._buttonEnabled == true ) 
				{
						if (Application.loadedLevelName =="StartScreen") {
								Application.LoadLevel ("Scen1");
						}
						if (Application.loadedLevelName =="Scen1") {
								Application.LoadLevel ("StartScreen");
						}
						if (Application.loadedLevelName =="Scen2") {
								Application.LoadLevel ("StartScreen");
						}
						if (Application.loadedLevelName == "Scen3") {
								Application.LoadLevel ("StartScreen");
						}

				}
				if (touchButtonRight2._buttonEnabled == true) {
						if (Application.loadedLevelName =="StartScreen") {	
								Application.LoadLevel ("Scen2");
						}
				}
				if (touchButtonRight3._buttonEnabled == true) {
						if (Application.loadedLevelName =="StartScreen") {	
								Application.LoadLevel ("Scen3");
						}
				}
				if (touchButtonRight4._buttonEnabled == true) {
						if (Application.loadedLevelName == "StartScreen") {
								Application.LoadLevel ("Scen4");
						}
				}
				if (touchButtonRight5._buttonEnabled == true) {
						if (Application.loadedLevelName == "StartScreen")
								Application.LoadLevel ("Scen5");
				}
			
	}
}
