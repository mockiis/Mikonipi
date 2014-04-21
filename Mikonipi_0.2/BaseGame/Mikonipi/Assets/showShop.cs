using UnityEngine;
using System.Collections;

public class showShop : MonoBehaviour
{
		//bakgrund
		public Texture backgroundTexture;
		public int numberofmeny = 0;
		GameObject Background;
		GUITexture bgTexture;
		public Texture standardBtnTexture;

		//avbrytknapp
		GameObject cancelBtn;
		GUITexture cancelBtnTexture;

		//köpknapp
		GameObject buyBtn;
		GUITexture buyBtnTexture;

		bool shopActive;

		//scrollvariabler
		Vector2 scrollPosition = Vector2.zero;
		//var och hur stor
		Rect scrollRect = new Rect(125, 100, 325, 380);

		///testlista tanken är att lista ut alla djur som finns i listan sedan i scrollen.
	    ArrayList djur = new ArrayList();

		void Start ()
		{

				djur.Add ("björn");

				shopActive = false;
				//skapar bakgrunden
				Background = new GameObject ("BackGround");
				bgTexture = (GUITexture)Background.AddComponent (typeof(GUITexture));
				bgTexture.texture = backgroundTexture;
				bgTexture.transform.position = new Vector3 (0.5f, 0.5f, 0);
				bgTexture.transform.localScale = new Vector3 (0.75f, 0.75f, 0);
				bgTexture.color = new Vector4 (255, 255, 255, 0.15f);

				//exitknappen
				cancelBtn = new GameObject ("Cancel");
				cancelBtnTexture = (GUITexture)cancelBtn.AddComponent (typeof(GUITexture));
				//ändra här sen för olika knappar
				cancelBtnTexture.texture = standardBtnTexture;
				cancelBtnTexture.transform.position = new Vector3 (0.8f, 0.25f, 1);
				cancelBtnTexture.transform.localScale = new Vector3 (0.1f, 0.1f, 0);

				//köpknappen
				buyBtn = new GameObject ("Buy");
				buyBtnTexture = (GUITexture)buyBtn.AddComponent (typeof(GUITexture));
				//ändra här sen för olika knappar
				buyBtnTexture.texture = standardBtnTexture;
				buyBtnTexture.transform.position = new Vector3 (0.8f, 0.35f, 1);
				buyBtnTexture.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
				

				DeactivateGUI ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetMouseButtonDown (0)) {
						if (gameObject.guiTexture.GetScreenRect ().Contains (Input.mousePosition) && shopActive == false) {
								shopActive = true;
								ActivateGUI ();
						} else if (gameObject.guiTexture.GetScreenRect ().Contains (Input.mousePosition) && shopActive == true) {
								shopActive = false;
								DeactivateGUI ();
						}
						if (cancelBtn.guiTexture.GetScreenRect ().Contains (Input.mousePosition)) {
								shopActive = false;
								DeactivateGUI ();
						}

				}
		}

		void ActivateGUI ()
		{
				Background.SetActive (true);
				cancelBtn.SetActive (true);
				buyBtn.SetActive (true);
		}
		
		void DeactivateGUI ()
		{
				Background.SetActive (false);
				cancelBtn.SetActive (false);
				buyBtn.SetActive (false);
		}

		void OnGUI ()
		{
		if (shopActive) {
						scrollPosition = GUI.BeginScrollView (scrollRect, scrollPosition, new Rect (0, 0, 300, 600), false, true);
						GUI.Button (new Rect (0, 0, 100, 20), "Top-left");
						GUI.Button (new Rect (120, 0, 100, 20), "Top-right");
						GUI.Button (new Rect (0, 180, 100, 20), "Bottom-left");
						GUI.Button (new Rect (120, 180, 100, 20), "Bottom-right");
						GUI.EndScrollView ();
				}
		}
}
