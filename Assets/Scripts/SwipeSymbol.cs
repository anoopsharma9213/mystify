using UnityEngine;
using System.Collections;

public class SwipeSymbol : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Camera.main.transform.position.y >= 20.0f) {
						transform.position = new Vector3 (Camera.main.transform.position.x + 5.6f, Camera.main.transform.position.y, 0);
				} else {
						transform.position = new Vector3 (12.8f, -10.0f, 0);
				}
	}
}
