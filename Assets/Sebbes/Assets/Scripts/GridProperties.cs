using UnityEngine;
using System.Collections;

public class GridProperties{


	static GridProperties mInstance;

	private int
		Widht,
		Height;

	public SquareStuff[,] testDerp;

	public  bool
		build = false,
		destroy = false;


	public static GridProperties Instance
	{

		get{
			if (mInstance == null)
					mInstance = new GridProperties ();
			return	mInstance;
			}
	}



	/**
	328.7999
	29.10003
	305.4
	-20
	-26.2
	-44
	**/
	public int GetWidht
	{
		get{return Widht;}
		set{Widht = value; }
	}

	public int GetHeight
	{
		get{return Height;}
		set{Height = value; }
	}
}
