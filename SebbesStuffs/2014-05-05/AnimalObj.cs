using UnityEngine;
using System.Collections;

public class AnimalObj : MonoBehaviour {


	private int Id
		,xPos
		,zPos;


	void Start () {}
	
	// Update is called once per frame
	void Update () {}


	public void OnGUI()
	{
		if (GlobalItems.Instance.stateAnimal) {
			if(GUI.Button(new Rect(60*7,Screen.height-60,60,60),"Cancel"))
			   {
				GlobalItems.Instance.selectedObj = null;
				GlobalItems.Instance.stateAnimal = false;
			}
			if(GUI.Button(new Rect(60*8,Screen.height-60,60,60),"Add"))
			{
				GlobalItems.Instance.objNameRef [(GlobalItems.Instance.selectedObj.name)] +=1;
				GlobalItems.Instance.position[xPos,zPos]=0;
				Destroy(GlobalItems.Instance.selectedObj);
				GlobalItems.Instance.stateAnimal = false;

			}
				}

	}
	

	void OnMouseOver()
	{
		if(Input.GetMouseButtonDown(0) && !GlobalItems.Instance.stateDrop && !GlobalItems.Instance.stateBuy){
			GlobalItems.Instance.selectedObj = gameObject;
			GlobalItems.Instance.stateAnimal = true;
			Debug.Log(Id);
		}
	}

	public int ConfigId {
		get { return Id; }
		set {	Id = value;	}
		}
	public int theXPos {
		get { return xPos; }
		set {	xPos = value;	}
	}
	public int theZPos  {
		get { return zPos; }
		set {	zPos = value;	}
	}


}
