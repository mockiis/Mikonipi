using UnityEngine;
using System.Collections;

public class SquareStuff: MonoBehaviour {




	public GameObject det;
	private GameObject ownedObj;
	Quaternion ful;

	// Use this for initialization
	void Start () {
		renderer.material.color = Color.cyan;
		ful = Quaternion.identity;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnGUI()
	{

	}

	public void OnMouseOver()
	{
				if (ownedObj == null) {
						if (Input.GetMouseButtonDown (0)) {
								Debug.Log (GridProperties.Instance.build);
								if (GridProperties.Instance.build) { 
										ownedObj = (GameObject)Instantiate (det, new Vector3 (transform.position.x, transform.position.y-0.2f, -1f), ful);
					ownedObj.transform.Rotate(180,0,90);
								}
						}
				} else if (Input.GetMouseButtonDown (0)) {
						if (GridProperties.Instance.destroy) {
								Destroy (ownedObj);
						}
				}
	}


	public void OnMouseEnter(){
		if(GridProperties.Instance.build)
			renderer.material.color = Color.red;
		else
			renderer.material.color = Color.black;

	//	Debug.Log ("Xpos: " + transform.position.x + "Ypos: " + transform.position.y);

		}

	public void OnMouseExit()
	{
		renderer.material.color = Color.cyan;

	}

}
