using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshRenderer))]
public class tileMap : MonoBehaviour {
	
	public int size_x;
	public int size_z;
	public float tileSize = 2.0f;

	public Texture2D terrain;
	public int tileRes;

	void Start () {
		BuildMesh ();
		
	}
	Color[][] ChopUpTiles() {
		//
		int numTilesPerRow = terrain.width / tileRes;
		int numRows = terrain.height / tileRes;
		
		Color[][] tiles = new Color[numTilesPerRow*numRows][];
		
		for(int y=0; y<numRows; y++) {
			for(int x=0; x<numTilesPerRow; x++) {
				tiles[y*numTilesPerRow + x] = terrain.GetPixels( x*tileRes , y*tileRes, tileRes, tileRes );
			}
		}
		
		return tiles;
	}
	
	void BuildTexture(){
		int tileRow = terrain.width /tileRes;
		int numTiles = terrain.height / tileRes;

		int texHeight = size_z * tileRes;
		int texWidth = size_x * tileRes;
		Texture2D texture = new Texture2D (texWidth, texHeight);

		Color[][] tiles = ChopUpTiles();
		
		for (int y = 0; y < size_z; y++) {
			for (int x = 0; x < size_x; x++) {

				Color[] p = tiles[0];
				texture.SetPixels(x * tileRes, y * tileRes, tileRes, tileRes, p);
			}
		}
		texture.filterMode = FilterMode.Bilinear;
		texture.wrapMode = TextureWrapMode.Clamp;
		texture.Apply();
		
		MeshRenderer mesh_renderer = GetComponent<MeshRenderer> ();
		mesh_renderer.sharedMaterials[0].mainTexture = texture;
		
		Debug.Log ("DoneTexture");
		
	}
	
	public void BuildMesh(){
		
		int numTiles = size_x * size_z;
		int vsize_x = size_x + 1;
		int vsize_z = size_z + 1;
		int numVerts = vsize_x * vsize_z;
		int numTirangle = numTiles * 2;
		
		Vector3[] vertices = new Vector3[numVerts];
		int[] triangles = new int[ numTirangle * 3];
		Vector3[] normals = new Vector3[numVerts];
		Vector2[] uv = new Vector2[numVerts];
		
		int x, z;
		for (z = 0; z < vsize_z; z++){
			for (x = 0; x < vsize_x; x++){
				vertices[z * vsize_x + x] = new Vector3 (x * tileSize, 0, z*tileSize);
				normals[z * vsize_x + x] = Vector3.up;
				uv[z * vsize_x + x] = new Vector2 ((float)x / size_x, (float)z / size_z);
			}
			
		}
		for ( z = 0; z < size_z; z++){
			for ( x = 0; x < size_x; x++){
				int squareIndex = z * size_x +x ;
				int triOffset = squareIndex * 6;
				triangles[triOffset + 0] = z * vsize_x + x + 0;
				triangles[triOffset + 1] = z * vsize_x + x + vsize_x + 0;
				triangles[triOffset + 2] = z * vsize_x + x + vsize_x + 1;
				
				triangles[triOffset + 3] = z * vsize_x + x + 0;
				triangles[triOffset + 4] = z * vsize_x + x + vsize_x + 1;
				triangles[triOffset + 5] = z * vsize_x + x + 1;
			}
			
		}
		
		
		Mesh mesh = new Mesh();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.normals = normals;
		mesh.uv = uv;
		
		
		MeshFilter mesh_filter = GetComponent<MeshFilter> ();
		MeshCollider mesh_collider = GetComponent<MeshCollider> ();
		MeshRenderer mesh_renderer = GetComponent<MeshRenderer> ();
		
		
		mesh_filter.mesh = mesh;
		mesh_collider.sharedMesh = mesh;

		BuildTexture();

		Debug.Log ("Donemesh");
		
	}
	
}