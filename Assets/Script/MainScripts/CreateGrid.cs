using UnityEngine;
using System.Collections;

public class CreateGrid : MonoBehaviour {

	public GameObject gridType;

	public float 
				SizeX,
				SizeY,
				SizeZ;
	public float
				Height = 50;

	private GridProperties prop;

	private SquareStuff	testa;

	private GameObject[,] derp = new GameObject[10,10];

	void Start () {
				for (int x = 0; x < 10; x++) {
						for (int y = 0; y < 10; y++) {
								Quaternion ful = Quaternion.identity;
								ful.SetFromToRotation(new Vector3(0,1,0), new Vector3(Height,0,1));
								derp [x, y] = (GameObject)Instantiate (gridType, new Vector3 (x * 1f, y * 1f, 0), ful);
						}
				}
		}
	// Update for future gridChanges.
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			//.GetComponent<SquareStuff> () för att ändra objtypen, enbart obj som pos, kör då bara GameObject
						derp [5, 5].transform.Rotate(new Vector3 (-5, 0, 0));
					Debug.Log("Test");		
		}

	
	}

}
