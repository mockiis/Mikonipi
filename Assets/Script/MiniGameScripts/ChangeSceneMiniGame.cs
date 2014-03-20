using UnityEngine;
using System.Collections;

public class ChangeSceneMiniGame : MonoBehaviour {

	string objectName;
	public Texture text_miniGame;
	GameObject miniGame_button;
	GUITexture gui_button;
	int numberofmeny = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			if (hit) 
			{
				objectName = hitInfo.transform.gameObject.name;
				switch(objectName)
				{
				case "MainPlanet":
					Application.LoadLevel ("Game1");

					break;
				case "Planet2":

					break;
				case"Planet3":

					break;
				case"Planet4":

					break;
				case"Planet5":

					break;
					
				}
				
			}
	}
 }

}