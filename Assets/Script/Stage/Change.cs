using UnityEngine;
using System.Collections;

public class Change : MonoBehaviour {

	public static int ring = 4;

	// Use this for initialization
	void Start () {
		ring = 4;
	}
	
	// Update is called once per frame
	void Update () {
		if (LevelBegin.play == true) {
						if (Application.platform == RuntimePlatform.WP8Player || Application.platform == RuntimePlatform.Android) {
								if (Input.GetTouch (0).phase == TouchPhase.Ended && Input.GetTouch (0).deltaPosition == Vector2.zero) {
										if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
												if (name == "b_inner" && ring < 4) {
														ring++;
												} else if (name == "b_outer" && ring > 1) {
														ring--;
												}
										}
								}
						} else {
								if (Input.GetKeyDown (KeyCode.LeftArrow) && ring > 1 && name == "b_outer") {
										ring--;
								} else if (Input.GetKeyDown (KeyCode.RightArrow) && ring < 4 && name == "b_inner") {
										ring++;
								}
						}
				}
	}
}
