using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

		public PlayerMovement playermoveScript;
		public PlayerMovment2 plmS;
		public CameraMovment cameramovenemtScript;
		public Transform obj_player;
		public Transform obj_player2;
	void Start () {
				playermoveScript = obj_player.GetComponent<PlayerMovement>();
				cameramovenemtScript = obj_player.GetComponent<CameraMovment> ();
				plmS = obj_player2.GetComponent<PlayerMovment2> ();
	}
	void Update () {
	}
		public void OnTriggerEnter2D(Collider2D other)
		{
				if (other.gameObject.tag == "Player") {
						Debug.Log ("Chubapalele");
				}
				if (other.gameObject.tag != "player") {
						playermoveScript.reset = true;

						if (Application.loadedLevelName == "Scen2") {
								plmS.reset = true;
						}
						if (Application.loadedLevelName == "Scen4") {
								Application.LoadLevel ("Scen4");
						}
						Debug.Log ("Nada");
				}
		}
}
