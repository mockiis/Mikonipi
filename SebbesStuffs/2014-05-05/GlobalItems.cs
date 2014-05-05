using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalItems {

	private static GlobalItems GI;

	public int tempId;


	public bool 
				stateDrop,
				stateAnimal,
				stateBuy,
				stateNormal;

	private List<GameObject> ListOfObj = new List<GameObject>();
	private List<GameObject> CurrentPlaneObj = new List<GameObject>();
	private List<int> nrOfItemsInDrop = new List<int>();

	public Dictionary<string, int> objNameRef = new Dictionary<string, int> ();
	public Dictionary<int, GameObject> objRef = new Dictionary<int, GameObject> ();

	public GameObject selectedObj = null;
	public static Random rand = new Random();
	public int[,] position;

	public float
				currency_Positiva;

	public static GlobalItems Instance
	{
		get
		{
			if (GI == null)
			{
				GI = new GlobalItems();
			}
			
			return GI;
		}
	}

	public List<int> configNrItems {
		get {
			return nrOfItemsInDrop;
		}
		set {
			nrOfItemsInDrop = value;
		}
	}

	public List<GameObject> configDropList {
				get {
						return ListOfObj;
				}
				set {
						ListOfObj = value;
				}
		}

	public List<GameObject> configMapList {
				get {
						return CurrentPlaneObj;
				}
				set {
						CurrentPlaneObj = value;
				}
		}
}
