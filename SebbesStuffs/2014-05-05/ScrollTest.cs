using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollTest : MonoBehaviour {

	public Vector2 
		scrollWindowSize,
		buttonSize;
	private float
		arise =  Screen.height;
	public int
		nrOfTarget;
	private Vector2
		scrollPosition,
		windowPosition = new Vector2(0, Screen.height - 60),
		btnSize = new Vector2(60,60),
		windowPadding = new Vector2(10,20);
	public List<GameObject>
		AnimalListOfObj;
	public int[,] test2Dposition;
	public GameObject SelectObj;

	private bool
		showBox = false;
//	public GameObject cub;


	void Awake()
	{
				scrollPosition = new Vector2 (GlobalItems.Instance.configDropList.Count * buttonSize.x - scrollWindowSize.x / 2, 0);


				for (int i = 0; i < AnimalListOfObj.Count; i++) {
						GlobalItems.Instance.objNameRef.Add (AnimalListOfObj [i].name + "(Clone)", (i + 1));
						GlobalItems.Instance.objRef.Add (i, AnimalListOfObj [i]);
				}
				//GlobalItems.Instance.configDropList [0].SetActive (false);
		}

	void Update(){
		SelectObj = GlobalItems.Instance.selectedObj;
		test2Dposition = GlobalItems.Instance.position;
		}

	void OnGUI() {

		if (GlobalItems.Instance.stateDrop) {
			if(GUI.Button(new Rect(60*7,Screen.height-60,60,60),"Cancel"))
			{
				GlobalItems.Instance.objNameRef [(GlobalItems.Instance.selectedObj.name + "(Clone)")] +=1;
				GlobalItems.Instance.selectedObj = null;
				GlobalItems.Instance.stateDrop = false;
			}

		}


				if (!showBox) {
			if(GUI.Button (new Rect (windowPosition.x, windowPosition.y, btnSize.x, btnSize.y), "Show"))
						showBox = true;
				}

				if (showBox){
			GUI.Window (0, new Rect (windowPosition.x+ btnSize.x, windowPosition.y-btnSize.y*0.666667f, btnSize.x*5,  btnSize.y*0.666667f+btnSize.y), DoMyWindow, "DropBox");

			if (GUI.Button (new Rect (windowPosition.x, windowPosition.y, btnSize.x, btnSize.y), "Hide"))
								showBox = false;

				}

		}


	void DoMyWindow(int windowID) {

		scrollPosition = GUI.BeginScrollView (new Rect (windowPadding.x, windowPadding.y, scrollWindowSize.x, buttonSize.y)
		                                      , scrollPosition, new Rect (0, 0, GlobalItems.Instance.objNameRef.Count * buttonSize.x, 0), false, false);

				Rect test = new Rect (0, 0, buttonSize.x, buttonSize.y);
				for (int i = 0; i <GlobalItems.Instance.objNameRef.Count; i++) {
						if (test.xMax >= scrollPosition.x && 
								test.xMin <= (scrollPosition.x + scrollWindowSize.x)) {
				if (GlobalItems.Instance.objNameRef [(AnimalListOfObj [i].name + "(Clone)")] > 0) {
										GUI.DrawTexture (test, GlobalItems.Instance.objRef [i].guiTexture.texture);
					if(GUI.Button (test, GUIContent.none) && !GlobalItems.Instance.selectedObj && !GlobalItems.Instance.stateBuy) {
												GlobalItems.Instance.selectedObj = GlobalItems.Instance.objRef[i];
												GlobalItems.Instance.tempId = i;
												GlobalItems.Instance.stateDrop = true;
										}
								}
								GUI.Label (test, "x:" + GlobalItems.Instance.objNameRef [(AnimalListOfObj [i].name + "(Clone)")]);
						}
						test.x += buttonSize.x;
				}

				GUI.EndScrollView ();
		}
}
