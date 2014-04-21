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
	public Texture exitBtn;

	GameObject GoButton;
	GUITexture GuiText_Go;
	public Texture goBtn;

		public Texture text;

		public Texture text_land;
		public Texture text_Iceland;
		public Texture text_Forest;
		public Texture text_Desert;

		string objectName;

	// Use this for initialization
	void Start () {
		//Keffes Dick är fan Ball
		GuiText_Exit.texture = exitBtn;
		GuiText_Go.texture = goBtn;
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
								case "desert":
										Debug.Log("Desert");
										land = "ScenGrund";
										text_land = text_Desert;
										objectName = "";
										numberofmeny++;
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

		}

		


		

	}
		void MakeMeny()
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
										if(numberofmeny == 0) {
												Destroy (Background);
												Destroy (info);
												Destroy (Landobject_Ice);
												Destroy (ExitButton);
												Destroy (GoButton);
										}
		}
}
