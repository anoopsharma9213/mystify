using UnityEngine;
using System.Collections;

public class Persistent : MonoBehaviour {

	public static bool music = true;
	public static bool sound = true;
	public static bool[] chapter = new bool[8]{true,false,false,false,false,false,false,false};
	public static bool[,] stages = new bool[8,8]{{true,false,false,false,false,false,false,false},
												{true,false,false,false,false,false,false,false},
												{true,false,false,false,false,false,false,false},
												{true,false,false,false,false,false,false,false},
												{true,false,false,false,false,false,false,false},
												{true,false,false,false,false,false,false,false},
												{true,false,false,false,false,false,false,false},
												{true,false,false,false,false,false,false,false}};
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
