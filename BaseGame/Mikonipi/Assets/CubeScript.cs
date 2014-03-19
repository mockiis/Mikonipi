using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

		Material material;

	// Use this for initialization
	void Start () {
				material= new Material(Shader.Find("Transparent/Diffuse"));
				//  gameObject.renderer.material.color = new Vector4 (255, 255, 255, 0.01f);
				material.mainTexture=null;
				gameObject.renderer.material = material;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
