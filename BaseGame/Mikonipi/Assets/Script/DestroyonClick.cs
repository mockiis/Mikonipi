﻿using UnityEngine;
using System.Collections;

public class DestroyonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
		public void OnMouseDown()
		{
				Destroy (this);
		}
}
