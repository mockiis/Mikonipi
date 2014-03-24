using UnityEngine;
using System.Collections;

public class TextureManager : MonoBehaviour {

	int size = 7;

	Material[] materials;
	public Texture waterTexture;
	public Texture bumpMap;
	public Texture snow;
	public Texture forest;
	public Texture djungle;
	public Texture desert;
	public Texture ocean;


	// Use this for initialization
	void Start () {
		materials = new Material[size];
		/*
		 texturerna laddas från \Mikonipi\Assets\Resources
		 0 = Vatten
		 1 = Snö
		 2 = Skog
		 3 = jungel
		 4 = öken
		 5 = savan
		 */
		Texture bumpMap = Resources.Load<Texture> ("scene select/pangea-1_NRM");

		materials[0] = new Material (Shader.Find ("Transparent/Diffuse"));
		materials [0].SetTexture("_MainTex", Resources.Load<Texture>("scene select/world-6-water"));
		//materials [0].color = Color.blue;

		materials [1] = new Material (Shader.Find ("Transparent/Bumped Diffuse"));
		materials[1].SetTexture("_MainTex", Resources.Load<Texture>("scene select/snow"));
		materials [1].SetTexture ("_BumpMap", bumpMap);

		materials [2] = new Material (Shader.Find ("Transparent/Bumped Diffuse"));
		materials[2].SetTexture("_MainTex", Resources.Load<Texture>("scene select/forest"));
		materials [2].SetTexture ("_BumpMap", bumpMap);

		materials [3] = new Material (Shader.Find ("Transparent/Bumped Diffuse"));
		materials[3].SetTexture("_MainTex", Resources.Load<Texture>("scene select/rainforest"));
		materials [3].SetTexture ("_BumpMap", bumpMap);

		materials [4] = new Material (Shader.Find ("Transparent/Bumped Diffuse"));
		materials[4].SetTexture("_MainTex", Resources.Load<Texture>("scene select/desert"));
		materials [4].SetTexture ("_BumpMap", bumpMap);

		materials [5] = new Material (Shader.Find ("Transparent/Bumped Diffuse"));
		materials[5].SetTexture("_MainTex", Resources.Load<Texture>("scene select/savannah"));
		materials [5].SetTexture ("_BumpMap", bumpMap);

		//sista texturen, bumpmap
		/*materials[size-1] = new Material(Shader.Find("Transparent/Bumped Diffuse"));
		materials[size-1].SetTexture("_MainTex", Resources.Load<Texture>("scene select/transparent"));
		materials [size-1].SetTexture ("_BumpMap", Resources.Load<Texture>("scene select/pangea-1_NRM"));*/


		renderer.materials = materials;  
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
