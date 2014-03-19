using UnityEngine;
using System.Collections;

public class GridSystem: MonoBehaviour {
	
	public GameObject gridType;
	public GameObject Clouds;


	private GridProperties prop;
	private GameObject[,] derp = new GameObject[10,10];
	private Quaternion ful;

	private float 
		SpawnPosX = -8,
		cloudStartPosY;
	private float time;
//	private GameObject herp = null;
	// Use this for initialization
	void Start () {
		ful = Quaternion.identity;
					for (int x = 0; x < 10; x++) {
							for (int y = 0; y < 10; y++) {
									derp [x, y] = (GameObject)Instantiate (gridType, new Vector3 (x * 1f, y * 1f, 0), ful);	
							}
					}
	}
	
	// Update for future gridChanges.
	void Update () {
		time += Time.deltaTime;

		if(time >1.8f){
			cloudStartPosY = Random.Range(-7,8);
			ful.SetFromToRotation(new Vector3(0,1,0),new Vector3(0,50,0));
			Instantiate(Clouds, new Vector3(SpawnPosX,cloudStartPosY,-5),ful);
			time = 0;
				}


	
	}

}
