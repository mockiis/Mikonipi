using UnityEngine;
using System.Collections;

public class TouchButtonRight : MonoBehaviour {
		private GUITexture _gui;
		public Vector2 MousePosition;
		public bool _buttonEnabled; 
	// Use this for initialization
	void Start () {
				//transform.localScale = Vector3.zero;
				_gui = GetComponent<GUITexture> ();
				_gui.pixelInset = new Rect (_gui.pixelInset.x, _gui.pixelInset.y,
						_gui.texture.width, _gui.texture.height);
	
	}
	
	// Update is called once per frame
	void Update () {
				_buttonEnabled = false; // we reset the button.

				foreach (Touch touch in Input.touches) 
				{
						if (_buttonEnabled) return;//don't go any further if this button is pressed.
						if (!_gui.HitTest(touch.position)) continue;//do hit test, we 'press' it??
						switch (touch.phase)
						{
						case TouchPhase.Began:
						case TouchPhase.Moved:
						case TouchPhase.Stationary:
								ButtonPressed();//We hit the button!
								return;//Return completely out of the update.
						}
				}
				if (_buttonEnabled) return;//don't go any further if this button is pressed.

				MousePosition = Input.mousePosition;
				if (!Input.GetMouseButton(0)) return;//Bugger off if no mouse press.
				if (!_gui.HitTest(MousePosition)) return;
				ButtonPressed(); //We hit the button!

		}
		private void ButtonPressed()
		{
				_buttonEnabled = true;//This button has been hit.
				//Debug.Log("Do incremental action here.");
		}
	
	}

