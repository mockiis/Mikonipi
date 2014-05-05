using UnityEngine;
using System.Collections;

public class Currency : MonoBehaviour {

	public float 
		currency,
		fontSizeX,
		fontSizeY,
		textureSizeX,
		textureSizeY;

	public Texture2D picture;
	private GUIText textAd;
	public Font font;
	void Start()
	{
		GlobalItems.Instance.currency_Positiva = currency;
		textAd = GetComponent<GUIText> ();
		textAd.font = font;

	}

	// Update is called once per frame
	void Update () {
		currency = GlobalItems.Instance.currency_Positiva;
		textAd.text = currency.ToString();
	}


	void OnGUI()
	{
		GUI.DrawTexture(new Rect(Screen.width - textureSizeX,0,textureSizeX,textureSizeY),picture);
		//GUI.Label(new Rect(Screen.width - textureSizeX,0,textureSizeX,textureSizeY),currency.ToString());

	}
}
