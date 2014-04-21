using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(tileMap))]
public class InspectorEditor : Editor {

	public override void OnInspectorGUI(){

		DrawDefaultInspector ();

		if (GUILayout.Button ("Regenerate")) {
						tileMap tileMap = (tileMap)target;
						tileMap.BuildMesh ();
				}
		                                  
	}
}
