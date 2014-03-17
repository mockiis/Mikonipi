using UnityEngine;
using System.Collections;

public class ShowMeny : MonoBehaviour {
		public TouchButton touchButton;
		public Transform obj_touchbutton;

		public SideMenuBehavior smb;
		public Transform obj_smb;

		public GameObject spawnMeny;
		public bool showMenybool = false;


		int numberofmeny = 0;
		GameObject Background;
		GUITexture bgTexture;

		GameObject Button1;
		GUITexture button1Texture;

		GameObject AnimalPic;
		GUITexture gui_animal_texture;

		GameObject BuyButton;
		GUITexture buyButtonTexture;

		GameObject info;
		GUIText infotext;

		GameObject stats;
		GUIText statstext;

		public string string_infotext;
		public string string_statstext;

		public Vector2 mousePosition;

		public Texture backgroundTexture;

		public Texture text_button;


		public Texture text_Animal;

		Rect rect;


	void Start () {
				touchButton = obj_touchbutton.GetComponent<TouchButton> ();
				smb = obj_smb.GetComponent<SideMenuBehavior> ();
				string_infotext = " Agge är fan king";
				string_statstext = "tiotusentvåhundrafyra";
	}
	void Update () {
				if (touchButton._buttonEnabled == true && numberofmeny == 0) {
						showMenybool = true;

				}
				if (showMenybool == true) {
						makeMeny ();



				}
				mousePosition = Input.mousePosition;
	}
		public void makeMeny()
		{

				if (numberofmeny == 0) {

						Background = new GameObject ("BackGround");
						bgTexture = (GUITexture)Background.AddComponent (typeof(GUITexture));
						bgTexture.texture = backgroundTexture;
						bgTexture.transform.position = new Vector3 (0.5f, 0.5f, 0);
						bgTexture.transform.localScale = new Vector3 (0.75f, 0.75f, 0);
						bgTexture.color = new Vector4 (255, 255, 255, 0.25f);

						Button1 = new GameObject ("Button1");
						button1Texture = (GUITexture)Button1.AddComponent (typeof(GUITexture));
						button1Texture.texture = text_button;
						button1Texture.transform.position = new Vector3 (0.8f, 0.25f, 1);
						button1Texture.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
						rect = new Rect (Button1.transform.position.x,Button1.transform.position.y,100,100);


						AnimalPic = new GameObject ("AnimalPic");
						gui_animal_texture = (GUITexture)AnimalPic.AddComponent (typeof(GUITexture));
						gui_animal_texture.transform.position = new Vector3 (0.3f, 0.6f, 1);
						gui_animal_texture.transform.localScale = new Vector3 (0.25f, 0.4f, 0);
						gui_animal_texture.texture = text_Animal;


						BuyButton = new GameObject ("BuyButton");
						buyButtonTexture = (GUITexture)BuyButton.AddComponent (typeof (GUITexture));
						buyButtonTexture.transform.position = new Vector3 (0.8f, 0.4f, 1);
						buyButtonTexture.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
						buyButtonTexture.texture = text_button;


						info = new GameObject ("info");
						infotext = (GUIText)info.AddComponent (typeof(GUIText));
						infotext.transform.position = new Vector3 (0.2f, 0.35f, 1);
						infotext.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
						infotext.color = Color.black;
						infotext.text = string_infotext;

						stats = new GameObject ("stats");
						statstext = (GUIText)stats.AddComponent (typeof(GUIText));
						statstext.transform.position = new Vector3 (0.7f, 0.8f, 1);
						statstext.transform.localScale = new Vector3 (0.1f, 0.1f, 0);
						statstext.color = Color.black;
						statstext.text = string_statstext;

						numberofmeny++;
				}
				if (numberofmeny <= 1) {
						if (Input.GetMouseButtonDown (0)) {

								if (button1Texture.GetScreenRect ().Contains (Input.mousePosition)) {
										Destroy (Background);
										Destroy (Button1);
										Destroy (AnimalPic);
										Destroy (BuyButton);
										Destroy (info);
										Destroy (stats);
										showMenybool = false;
										numberofmeny--;
										Debug.Log ("Exit");
								}
								if (buyButtonTexture.GetScreenRect ().Contains (Input.mousePosition)) {
										Debug.Log ("Köpknapp");
								}
						}
				}
		}

}
