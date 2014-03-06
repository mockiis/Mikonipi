using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

		public CameraMovment cMovement;
		public Transform obj_camera;

		public Timer timer;
		public Transform obj_timer;

		public PointManager pManager;
		public Transform obj_pManager;

		public string jumpButton = "Fire1";
		public float jumppower = 10.0f;
		public float playerSpeed = 0.2f;
		public float deathtime = 2.5f;
		public float deathtimereset = 2.5f;
		public Rigidbody2D rigidbody2d;
		public bool reset= false;
		public bool movement = false;
		public bool resetGame  = false;
	// Use this for initialization
	void Start ()
		{
				rigidbody2d = gameObject.GetComponent<Rigidbody2D> ();		
				cMovement = obj_camera.GetComponent<CameraMovment> ();
				if(Application.loadedLevelName==("Scen3")|| Application.loadedLevelName==("Scen5")
						|| Application.loadedLevelName==("Scen7"))
				{
				timer = obj_timer.GetComponent<Timer> ();
				}
				if (Application.loadedLevelName == ("Scen7")) {
						pManager = obj_pManager.GetComponent<PointManager> ();
				}
	   }
	
	// Update is called once per frame
	void Update () 
		{
				if (Input.GetButton ("Fire1") && reset == false) 
				{
						rigidbody2d.AddForce (transform.up * jumppower);
						movement = true;
						cMovement.movment = true;
						if (Application.loadedLevelName == ("Scen3") || Application.loadedLevelName == ("Scen5")
						   || Application.loadedLevelName == ("Scen7")) 
						{
								timer.startTimer = true;
						}
				}

				if(Application.loadedLevelName==("Scen3")|| Application.loadedLevelName==("Scen5")
						|| Application.loadedLevelName==("Scen7")){
				if (timer.timesUp == true) 
				{
								if(Application.loadedLevelName!=("Scen7"))
								{
										reset = true;
										timer.reset = true;
										if(Application.loadedLevelName==("Scen5"))
										{
												Application.LoadLevel("Scen5");
										}
										Debug.Log ("resetGame");
								}
								if (Application.loadedLevelName == ("Scen7")) {
										deathtime -= Time.deltaTime;
										movement = false;
										cMovement.movment = false;
										rigidbody2d.Sleep ();
										if (deathtime < 0) {
												reset = true;
												timer.reset = true;
												Application.LoadLevel ("Scen7");
										}
										Debug.Log ("resetGame");
								}

						}
								
				}
			
				if (reset == true) 
				{

								movement = false;
								cMovement.reset = true;
								Vector3 newposition = transform.position;
								newposition.y = 3;
								newposition.x = -2;
								deathtime = deathtimereset;
								gameObject.transform.position = newposition;
								deathtime = deathtimereset;
								rigidbody2d.Sleep ();
								reset = false;
						

				}
				if (movement == true) 
				{
						transform.position += transform.right * playerSpeed;
				}


	}
}


