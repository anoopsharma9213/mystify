using UnityEngine;
using System.Collections;

public class Play_Glow : MonoBehaviour {

	public bool reverse = false;
	public static bool run = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (run == true) {
						if (reverse == false) {
								SpriteRenderer sr = renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a += 0.01f;
								if (temp.a > 1) {
										temp.a = 1.0f;
										reverse = true;
								}
								sr.color = temp;
						} else {
								SpriteRenderer sr = renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a -= 0.01f;
								if (temp.a < 0) {
										temp.a = 0.0f;
										reverse = false;
								}
								sr.color = temp;
						}
				}
	}
}
