using UnityEngine;
using System.Collections;

public class TileMapMouse : MonoBehaviour {

	public GameObject placeCube;
	tileMap _tileMap;
	public Transform obj_tilemap;
	Vector3 placeCoord;
	Vector3 currentTileCoord;
	public Transform selectionCube;

	public int[,] position;

	void Start(){
		_tileMap = obj_tilemap.GetComponent<tileMap> ();
		position = new int[_tileMap.size_x,_tileMap.size_z];
				
		}
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.mainCamera.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;
		if (collider.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			//sätter position till närmsta heltal utifrån var man träffar på planet
			int x = Mathf.FloorToInt (hitInfo.point.x);
			int z = Mathf.FloorToInt (hitInfo.point.z);

			//float y = Input.mousePosition.y;

			//y = Mathf.FloorToInt (hitInfo.point.y);

		
			//Debug.Log (Input.mousePosition);
			Debug.Log("Currx: " + currentTileCoord.x +"currz: " + currentTileCoord.z);
			currentTileCoord.x = x;
			currentTileCoord.z = z;

			selectionCube.transform.position = new Vector3(currentTileCoord.x, currentTileCoord.y, currentTileCoord.z);
		} 
		else {
		}
		if (Input.GetMouseButtonDown (0)) {
			//placera objekt
			//vi bör ej ta från prefab, istället använda oss av scripts och klasser, dessutom spara i lista så vi enklare kan hantera sparning osv.
			if(position[(int)currentTileCoord.x,(int)currentTileCoord.z] == 0)
			{
			currentTileCoord.x = currentTileCoord.x;
			currentTileCoord.z = currentTileCoord.z;

			GameObject thingy;
			thingy = (GameObject)Instantiate(placeCube, new Vector3(currentTileCoord.x + 1.0f, currentTileCoord.y + 0.5f, currentTileCoord.z + 0.5f), selectionCube.transform.rotation);
			Debug.Log ("Done Clone");
				position[(int)currentTileCoord.x,(int)currentTileCoord.z]=1;
			}

		}
	}
}