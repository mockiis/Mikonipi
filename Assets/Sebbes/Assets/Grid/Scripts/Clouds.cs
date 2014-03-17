using UnityEngine;
using System.Collections;

public class Clouds : MonoBehaviour {

	public Texture 
		text;

	public float
		SpeedMax,
		SpeedMin;

	public bool 
		dirX,
		dirY,
		dirZ;

	private float
		directionSpeed;
	
	// Use this for initialization
	void Start () {
		renderer.material.SetTexture (0, text);
		directionSpeed = Random.Range (SpeedMin, SpeedMax);
	}

	public void OnBecameInvisible()
	{
		DestroyObject(this.gameObject);
	}


	// Update is called once per frame
	void Update () {


		if (dirX)
			transform.Translate (new Vector3 (directionSpeed/2, 0, 0));
		if (dirY)
			transform.Translate(new Vector3(0,0,directionSpeed/60));

		renderer.Render (0);
	}
}
