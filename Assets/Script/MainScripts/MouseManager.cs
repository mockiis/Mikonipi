using UnityEngine;
using System.Collections;



public class MouseManager : MonoBehaviour {
	public GameObject mainCamera;
	public GameObject mo;
		string land;
		int numberofmeny = 0;

		GameObject Background;
		GUITexture bgTexture;

		GameObject info;
		GUIText infotext;

		GameObject Landobject_Ice;
		GUITexture Guitext_iceland;

		GameObject ExitButton;
		GUITexture GuiText_Exit;

		GameObject GoButton;
		GUITexture GuiText_Go;

		GameObject right_button;
		GUITexture right_text;

		GameObject left_button;
		GUITexture left_text;
	

		public Texture text;

		public Texture text_land;
		public Texture text_Iceland;
		public Texture text_Forest;
		public Texture text_Desert;

		string objectName;

		public int scenSelect = 1;
		public int totalEkoSystem = 3;

	// Use this for initialization
	void Start () {
//				right_button = new GameObject ("rightButton");
//				right_text = (GUITexture)right_button.AddComponent (typeof(GUITexture));
//				right_text.transform.position = new Vector3 (0.9f, 0.1f, 0);
//				right_text.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
//				right_text.texture = text;
//
//				left_button = new GameObject ("leftButton");
//				left_text = (GUITexture)left_button.AddComponent (typeof(GUITexture));
//				left_text.transform.position = new Vector3 (0.1f, 0.1f, 0);
//				left_text.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
//				left_text.texture = text;
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
								case "Iceland":
										Debug.Log ("Iceland");
										land = objectName;
										text_land = text_Iceland;
										objectName = "";
										numberofmeny++;


					break;
				case "Forest":
					
										Debug.Log ("Forest");
										land = objectName;
										text_land = text_Forest;
										objectName = "";
										numberofmeny++;
					break;
				case"Ocean":
					Debug.Log("Ocean clicked");
					break;
								case"Desert":
										Debug.Log("Desert");
										land = "EkoGrid";
										text_land = text_Desert;
										objectName = "";
										numberofmeny++;
										break;
				case"Savan":
						Debug.Log("Savan clicked");
					break;
				case"Snow":
						Debug.Log("Snow clicked");
					break;
				
				}
										
			}

						if (ExitButton!=null && GoButton !=null) {
								if (Input.GetMouseButtonDown (0)) {

										if (GuiText_Exit.GetScreenRect ().Contains (Input.mousePosition)) {

												numberofmeny = 0;
												Debug.Log ("Exit");
										}
										if (GuiText_Go.GetScreenRect ().Contains (Input.mousePosition)) {
												Application.LoadLevel (land);
										}
								}
						}
						MakeMeny ();
						//ChangePosition ();	
		}
	}
		public void MakeMeny()
		{
				if (numberofmeny == 1) {

						Background = new GameObject ("BackGround");
						bgTexture = (GUITexture)Background.AddComponent (typeof(GUITexture));
						bgTexture.texture = text;
						bgTexture.transform.position = new Vector3 (0.8f, 0.5f, 0);
						bgTexture.transform.localScale = new Vector3 (0.35f, 0.75f, 0);
						bgTexture.color = new Vector4 (255, 255, 255, 0.25f);

						info = new GameObject ("info");
						infotext = (GUIText)info.AddComponent (typeof(GUIText));
						infotext.transform.position = new Vector3 (0.75f, 0.85f, 1);
						infotext.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
						infotext.color = Color.black;
						infotext.text = land;
						infotext.fontSize = 35;

						Landobject_Ice = new GameObject ("LandObject");
						Guitext_iceland = (GUITexture)Landobject_Ice.AddComponent (typeof(GUITexture));
						Guitext_iceland.transform.position = new Vector3 (0.80f, 0.55f, 1);
						Guitext_iceland.transform.localScale = new Vector3 (0.25f, 0.4f, 0);
						Guitext_iceland.texture = text_land;

						ExitButton = new GameObject ("ExitButton");
						GuiText_Exit = (GUITexture)ExitButton.AddComponent (typeof(GUITexture));
						GuiText_Exit.transform.position = new Vector3 (0.72f, 0.25f, 1);
						GuiText_Exit.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
						GuiText_Exit.texture = text;

						GoButton = new GameObject ("GoButton");
						GuiText_Go = (GUITexture)GoButton.AddComponent (typeof(GUITexture));
						GuiText_Go.transform.position = new Vector3 (0.85f, 0.25f, 1);
						GuiText_Go.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
						GuiText_Go.texture = text;

						numberofmeny++;

				}
				if (numberofmeny == 0) {
						Destroy (Background);
						Destroy (info);
						Destroy (Landobject_Ice);
						Destroy (ExitButton);
						Destroy (GoButton);
				}
		}
		public void ChangePosition()
		{
				if (Input.GetMouseButtonDown (0)) {

						if (right_text.GetScreenRect ().Contains (Input.mousePosition)) {
								if (scenSelect < totalEkoSystem) {
										scenSelect++;
								}
								Debug.Log (scenSelect);
						}
						if (left_text.GetScreenRect ().Contains (Input.mousePosition)) {
								if (scenSelect != 1) {
										scenSelect--;
								}
								Debug.Log (scenSelect);
						}

				}
		}
}
