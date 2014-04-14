using UnityEngine;
using System.Collections;



public class MouseManager : MonoBehaviour {
	public GameObject mainCamera;
	public GameObject mo;

	// Use this for initialization
	void Start () {
		//Keffes Dick är fan Ball
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
				Debug.Log(hitInfo.transform.name + " clicked!");
				switch(objectName)
				{
								case "desert":
										Debug.Log ("Desert clicked");
										Application.LoadLevel ("ScenGrund");
					break;
				case "forest":
					Debug.Log("Forest clicked");
					break;
				case"ocean":
					Debug.Log("Ocean clicked");
					break;
				case"rainforest":
						Debug.Log("Rain forest clicked");
					break;
				case"savan":
						Debug.Log("Savan clicked");
					break;
				case"snow":
						Debug.Log("Snow clicked");
					break;
				//add more case for every eco-system
				}
				
			}
		}
	}
}
