using UnityEngine;
using System.Collections;

public class SquareTile : MonoBehaviour {




	// Use this for initialization
	void Start () {
		renderer.material.color = Color.cyan;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI()
	{


	}

	public void OnMouseOver(){
		renderer.material.color = Color.black;
	
	}


	public void OnMouseEnter(){
	renderer.material.color = Color.black;
		Debug.Log ("Xpos: " + transform.position.x + "Ypos: " + transform.position.y);
		}

	public void OnMouseExit()
	{
		renderer.material.color = Color.cyan;

	}

}
