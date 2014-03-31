using UnityEngine;
using System.Collections;

public class SideMenuBehavior : MonoBehaviour {

		public TouchButton touchbutton;
		public Transform obj_tb;
		public bool moveMenu = false;
		public bool menuactive = false;
		float speed = 0.01f;
		public int menumove = 0;

		int nrMenu = 0;
		int creatMenu = 0;

		GameObject BackGround;
		GUITexture text_backGround;

		GameObject level1;
		GUITexture text_level1;

		public Texture text;




	// Use this for initialization
	void Start () {
				touchbutton = obj_tb.GetComponent<TouchButton> ();
	
	}
	
	// Update is called once per frame
	void Update () {
				Movement ();
				if (Input.GetMouseButtonDown (0)) {
						if (level1 != null && text_level1.GetScreenRect ().Contains (Input.mousePosition)) {
								Debug.Log ("Application.loadlevel(insertlevel)");
						}
				}
					
	
	}
		public void Movement()
		{
				if (Input.GetMouseButtonDown (0)) {
						if (gameObject.guiTexture.GetScreenRect().Contains(Input.mousePosition) && menuactive == false) {
								menumove++;
								menuactive = true;
						}
				}
				if (menuactive == true) {
						if (menumove % 2 != 0 && gameObject.transform.position.x <= 0.3f) {
								makeMenu ();

								gameObject.transform.position += transform.right * speed;
								text_backGround.transform.position += transform.right * speed;
								text_level1.transform.position += transform.right * speed;
								Debug.Log ("moveRight");

								if (gameObject.transform.position.x >= 0.3f) {
										gameObject.transform.position = new Vector3 (0.3f,0.5f,0f);
										menuactive = false;

								}
						}

						if (menumove % 2 == 0 && gameObject.transform.position.x >= 0.07f) {

								gameObject.transform.position -= transform.right * speed;
								text_backGround.transform.position -= transform.right * speed;
								text_level1.transform.position -= transform.right * speed;
								Debug.Log ("MoveLeft");
								if (gameObject.transform.position.x <= 0.07f) {
										gameObject.transform.position = new Vector3 (0.07f,0.5f,0f);
										DestroyMenu ();
										menuactive = false;

								}
						}

				}
		}
	
		public void makeMenu()
		{
				if (creatMenu == 0) {
						BackGround = new GameObject ("SlideMenuBackGround");
						text_backGround = (GUITexture)BackGround.AddComponent (typeof(GUITexture));
						text_backGround.transform.position = new Vector3 (-0.20f, 0.95f, 0);
						text_backGround.transform.localScale = new Vector3 (0.4f, 1.9f, 0f);
						text_backGround.color = Color.black;
						text_backGround.texture = text;

						level1 = new GameObject ("LevelButton1");
						text_level1 = (GUITexture)level1.AddComponent (typeof(GUITexture));
						text_level1.transform.position = new Vector3 (-0.12f, 0.95f, 1);
						text_level1.transform.localScale = new Vector3 (0.1f, 0.1f, 0f);
						text_level1.color = Color.magenta;
						text_level1.texture = text;
						creatMenu++;
				}
		}
		public void DestroyMenu()
		{
				Destroy (BackGround);
				Destroy (level1);
				creatMenu--;
		}
}

