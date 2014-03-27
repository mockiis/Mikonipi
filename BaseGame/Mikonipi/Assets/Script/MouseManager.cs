using UnityEngine;
using System.Collections;



public class MouseManager : MonoBehaviour {
	public GameObject mainCamera;
	public GameObject mo;

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
				string objectName = hitInfo.transform.gameObject.name;
				switch(objectName)
				{
								case "Desert":
										Debug.Log ("Desert clicked");
										Application.LoadLevel ("ScenGrund");
					break;
				case "Forest":
					Debug.Log("Forest clicked");
					break;
				case"Ocean":
					Debug.Log("Ocean clicked");
					break;
				case"RainForest":
						Debug.Log("Rain forest clicked");
					break;
				case"Savan":
						Debug.Log("Savan clicked");
					break;
				case"Snow":
						Debug.Log("Snow clicked");
					break;
				//add more case for every eco-system
				}
				
			}
		}
	}
}
