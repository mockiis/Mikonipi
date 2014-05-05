using UnityEngine;
using System.Collections;

public class GameButton : MonoBehaviour {

	// Use this for initialization

	public GameObject menuObj;


	void Start () {
	
	}


	public void OnGUI()
	{
		if (GUI.Button (new Rect (10, 10, 120, 120), "Build")) {
			if(GridProperties.Instance.build)
				GridProperties.Instance.build = false;
			else
				GridProperties.Instance.build = true;	
		}

		if (GUI.Button (new Rect (10, 180, 120, 120), "Destroy")) {
			if(GridProperties.Instance.build)
				GridProperties.Instance.destroy = false;
			else
				GridProperties.Instance.destroy = true;	
		}


		if(GUI.Button(new Rect(Screen.width-100,Screen.height-80,100,80),"Meny"))
		{
			Instantiate(menuObj);
		}

	}


	// Update is called once per frame
	void Update () {
	
	}
}
