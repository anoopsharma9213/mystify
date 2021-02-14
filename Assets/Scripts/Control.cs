using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	public static string selected = null;
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = renderer as SpriteRenderer;
		//dir = 0;
	}
	
	// Update is called once per frame
	void Update () {

		/*if (Input.GetButton("Fire1")) {
			
						if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.mousePosition))) {
								selected = name;
						}
				}*/
		if (Motion.complete == false && (transform.parent.name == "L"+Motion.level && transform.parent.transform.parent.name == "C"+MenuControl.subpage)) {
						if (Input.touchCount > 0) {

								if (Input.GetTouch (0).phase == TouchPhase.Ended && Input.GetTouch (0).deltaPosition == Vector2.zero) {
										if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
												selected = name;
										}
								}

								if (Input.GetTouch (0).phase == TouchPhase.Moved && selected == name) {
										if (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).x >= Camera.main.transform.position.x+5.0f) {
												if (Input.GetTouch (0).deltaPosition.y > 0) {
														transform.Rotate (new Vector3 (0, 0, 1), 3);
														//dir = 1;
												} else if (Input.GetTouch (0).deltaPosition.y < 0) {
														transform.Rotate (new Vector3 (0, 0, 1), -3);
														//dir = -1;
												}
										}/* else {
												if (Input.GetTouch (0).deltaPosition.y > 0) {
														transform.Rotate (new Vector3 (0, 0, 1), -3);
														//dir = 1;
												} else if (Input.GetTouch (0).deltaPosition.y < 0) {
														transform.Rotate (new Vector3 (0, 0, 1), 3);
														//dir = -1;
												}
										}*/
								}
								Quaternion rot = transform.rotation;
								if (Input.GetTouch (0).phase == TouchPhase.Ended && selected == name) {
										/*if (dir == 1) {
										rot.eulerAngles = new Vector3 (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, ((int)(transform.rotation.eulerAngles.z) / 30) * 30);
										transform.rotation = rot;
										dir = 0;
								} else if (dir == -1) {
										rot.eulerAngles = new Vector3 (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, ((int)(transform.rotation.eulerAngles.z) / 30 + 1) * 30);
										transform.rotation = rot;
										dir = 0;
								}*/
										rot.eulerAngles = new Vector3 (transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z >= ((((int)(transform.rotation.eulerAngles.z) / 30) * 30) + (((int)(transform.rotation.eulerAngles.z) / 30 + 1) * 30)) / 2 ? (((int)(transform.rotation.eulerAngles.z) / 30 + 1) * 30) : (((int)(transform.rotation.eulerAngles.z) / 30) * 30));
										transform.rotation = rot;
								}
						}

						if (selected == name) {
								Color temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
								//Debug.Log (sr.color + "   "+ selected + "  " + name);
						} else {
								Color temp = sr.color;
								temp.a = 0.5f;
								sr.color = temp;
								//Debug.Log (sr.color + "   "+ selected + "  " + name);
						}
				}
	}
}