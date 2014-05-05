using UnityEngine;
using System.Collections;

public class BuyWindow1 : MonoBehaviour {
	

	private Vector3
		buyWindowButton = new Vector3(Screen.width*0.9f,Screen.height*0.9f),
		windowPosition = new Vector3(Screen.width*0.1f,Screen.height*0.1f),
		windowPSize = new Vector3(Screen.width*0.8f,Screen.height*0.8f);

	private Vector2
		butnSize = new Vector2(60,60),
		objPositon,
		textPosition;

	public Texture2D 
		backGroundText;

	// Use this for initialization
	void Start () {
	}

	void OnGUI()
	{
		if(!GlobalItems.Instance.stateBuy)
		if (GUI.Button (new Rect (buyWindowButton.x- butnSize.x/2, buyWindowButton.y - butnSize.y/2, butnSize.x* 1.5f, butnSize.y*1.5f), "Buy")) {
			GlobalItems.Instance.stateBuy = true;
				}
		if (GlobalItems.Instance.stateBuy) {
						GUI.Window (1, new Rect (windowPosition.x, windowPosition.y, windowPSize.x, windowPSize.y), DoMyWindow, "BuyShit");
				}
	}
		

	void DoMyWindow(int windowID) {
		
		objPositon = GUI.BeginScrollView (new Rect (5, 20, windowPSize.x, butnSize.y * 4)
		                                      , objPositon, new Rect (0, 0, 0, butnSize.y * 20), false, false);
			
		Rect test = new Rect (0, 0, butnSize.x, butnSize.y);
		for (int X = 0; X < 5; X++)
		{
			for (int Y = 0; Y < 20; Y++){

				if(GUI.Button(new Rect(X*butnSize.x,Y*butnSize.y,butnSize.x,butnSize.y), "X:"+X+"Y:"+Y) && GlobalItems.Instance.currency_Positiva >= 20){
					GlobalItems.Instance.objNameRef["test0"+"(Clone)"] += 1;
					GlobalItems.Instance.currency_Positiva -= 20;
				}
				}
		}
		GUI.EndScrollView ();
		/*
		 * 
		 * 
		 */
		textPosition = GUI.BeginScrollView (new Rect (0, butnSize.y * 4, windowPSize.x, butnSize.y * 4)
		                                    , textPosition, new Rect (0, 0, 0, butnSize.y * 4), false, false);
		GUI.Label (new Rect (40, 80, 200, 200), "Fungerar med lite finess");
		if (GUI.Button (new Rect (windowPSize.x - (butnSize.x * 2), butnSize.y * 3, butnSize.x * 2, butnSize.y), "Cancel")) {
			GlobalItems.Instance.stateBuy = false;
				}
		GUI.EndScrollView ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
