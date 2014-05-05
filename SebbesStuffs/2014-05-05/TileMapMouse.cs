using UnityEngine;
using System.Collections;

public class TileMapMouse : MonoBehaviour {

	tileMap _tileMap;
	public Transform obj_tilemap;
	Vector3 placeCoord;
	Vector3 currentTileCoord;
	public Transform selectionCube;
	

	void Start(){
		_tileMap = obj_tilemap.GetComponent<tileMap> ();
		GlobalItems.Instance.position = new int[_tileMap.size_x,_tileMap.size_z];
				
		}
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;
		//if (collider.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			//sätter position till närmsta heltal utifrån var man träffar på planet
		//	currentTileCoord.x = Mathf.FloorToInt (hitInfo.point.x);
		//	currentTileCoord.z = Mathf.FloorToInt (hitInfo.point.z);
			//float y = Input.mousePosition.y;
			//y = Mathf.FloorToInt (hitInfo.point.y);
			//Debug.Log (Input.mousePosition);
			//Debug.Log("Currx: " + currentTileCoord.x +"currz: " + currentTileCoord.z);

		//	selectionCube.transform.position = new Vector3(currentTileCoord.x, currentTileCoord.y, currentTileCoord.z);
		//} 
		if(Input.GetMouseButton (0) && GlobalItems.Instance.stateDrop && collider.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			//placera objekt
			//vi bör ej ta från prefab, istället använda oss av scripts och klasser, dessutom spara i lista så vi enklare kan hantera sparning osv.
			currentTileCoord.x = Mathf.FloorToInt (hitInfo.point.x);
			currentTileCoord.z = Mathf.FloorToInt (hitInfo.point.z);
			if(GlobalItems.Instance.position[(int)currentTileCoord.x,(int)currentTileCoord.z] == 0)
			{
				Quaternion derpi = Quaternion.AngleAxis(90.0f,new Vector3(-1f,0,0));//new Vector3(-1f,Random.Range(-0.1f,0.1f),Random.Range(0.1f,0.1f)));

				//selectionCube.transform.rotation
				GameObject temp = (GameObject)Instantiate(GlobalItems.Instance.selectedObj, new Vector3(currentTileCoord.x + 1.0f, currentTileCoord.y + 0.5f, currentTileCoord.z + 0.5f),derpi);
				temp.GetComponent<AnimalObj>().theXPos = (int)currentTileCoord.x;
				temp.GetComponent<AnimalObj>().theZPos = (int)currentTileCoord.z;
				temp.GetComponent<AnimalObj>().ConfigId = GlobalItems.Instance.tempId;
				Debug.Log(currentTileCoord.x+" "+ currentTileCoord.z);
				GlobalItems.Instance.objNameRef [(GlobalItems.Instance.selectedObj.name + "(Clone)")] -= 1;
				GlobalItems.Instance.stateDrop = false;
				GlobalItems.Instance.selectedObj = null;

					
			//Debug.Log ("Done Clone");
				GlobalItems.Instance.position[(int)currentTileCoord.x,(int)currentTileCoord.z]=1;
			}

		}
		else if(Input.GetMouseButton (0) && GlobalItems.Instance.stateAnimal && collider.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			//placera objekt
			//vi bör ej ta från prefab, istället använda oss av scripts och klasser, dessutom spara i lista så vi enklare kan hantera sparning osv.
			currentTileCoord.x = Mathf.FloorToInt (hitInfo.point.x);
			currentTileCoord.z = Mathf.FloorToInt (hitInfo.point.z);
			if(GlobalItems.Instance.position[(int)currentTileCoord.x,(int)currentTileCoord.z] == 0)
			{
				Quaternion derpi = Quaternion.AngleAxis(90.0f,new Vector3(-1f,0,0));
				//Quaternion derpi = Quaternion.AngleAxis(90.0f,new Vector3(-1f,0,0));//new Vector3(-1f,Random.Range(-0.1f,0.1f),Random.Range(0.1f,0.1f)));

				Debug.Log(GlobalItems.Instance.selectedObj.GetComponent<AnimalObj>().ConfigId);
				GameObject temp = (GameObject)Instantiate(GlobalItems.Instance.objRef[GlobalItems.Instance.selectedObj.GetComponent<AnimalObj>().ConfigId],
				            new Vector3(currentTileCoord.x + 1.0f, currentTileCoord.y + 0.5f, currentTileCoord.z + 0.5f),derpi);

				GlobalItems.Instance.position[GlobalItems.Instance.selectedObj.GetComponent<AnimalObj>().theXPos,
				                              GlobalItems.Instance.selectedObj.GetComponent<AnimalObj>().theZPos]=0;

				temp.GetComponent<AnimalObj>().theXPos = (int)currentTileCoord.x;
				temp.GetComponent<AnimalObj>().theZPos = (int)currentTileCoord.z;
				temp.GetComponent<AnimalObj>().ConfigId = GlobalItems.Instance.selectedObj.GetComponent<AnimalObj>().ConfigId;

				Debug.Log(currentTileCoord.x+" "+ currentTileCoord.z);

				GlobalItems.Instance.stateAnimal = false;
				Destroy(GlobalItems.Instance.selectedObj);
				
				
				//Debug.Log ("Done Clone");
				GlobalItems.Instance.position[(int)currentTileCoord.x,(int)currentTileCoord.z]=1;
			}
			
		}

	}
}