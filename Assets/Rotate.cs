using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	int rot_speed = 2;
	int rot_angle = 10;
	SpriteRenderer sr;
	public static bool control_active = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (LevelBegin.play == true) {
						if (gameObject.name == Change.ring.ToString ()) {
								sr = renderer as SpriteRenderer;
								Color ctemp = sr.color;
								ctemp.a = 1.0f;
								sr.color = ctemp;
								Quaternion temp = transform.rotation;
								if (Application.platform == RuntimePlatform.WP8Player || Application.platform == RuntimePlatform.Android) {
										if (Input.touchCount > 0) {				
												if (Input.GetTouch (0).phase == TouchPhase.Moved) {
														if (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).x >= Camera.main.transform.position.x + 4.0f) {
																GameObject.Find ("b_swipe").transform.position = new Vector3 (5, Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position).y);
																if (Input.GetTouch (0).deltaPosition.y > 0) {
																		temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, (float)((int)temp.eulerAngles.z + Input.GetTouch (0).deltaPosition.y));
																		transform.rotation = temp;
																} else if (Input.GetTouch (0).deltaPosition.y < 0) {
																		temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, (float)((int)temp.eulerAngles.z + Input.GetTouch (0).deltaPosition.y));
																		transform.rotation = temp;
																}
														}
												}

												if (Input.GetTouch (0).phase == TouchPhase.Ended) {
														temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, temp.eulerAngles.z >= ((((int)(temp.eulerAngles.z) / rot_angle) * rot_angle) + (((int)(temp.eulerAngles.z) / rot_angle + 1) * rot_angle)) / 2 ? (((int)(temp.eulerAngles.z) / rot_angle + 1) * rot_angle) : (((int)(temp.eulerAngles.z) / rot_angle) * rot_angle));
														transform.rotation = temp;
														GameObject.Find ("b_swipe").transform.position = new Vector3 (5, 0);
												}
										} else {
												temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, temp.eulerAngles.z >= ((((int)(temp.eulerAngles.z) / rot_angle) * rot_angle) + (((int)(temp.eulerAngles.z) / rot_angle + 1) * rot_angle)) / 2 ? (((int)(temp.eulerAngles.z) / rot_angle + 1) * rot_angle) : (((int)(temp.eulerAngles.z) / rot_angle) * rot_angle));
												transform.rotation = temp;
										}
								} else {
										if (Input.GetKey (KeyCode.UpArrow)) {
												temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, (float)((int)temp.eulerAngles.z + rot_speed));
												transform.rotation = temp;
										} else if (Input.GetKey (KeyCode.DownArrow)) {
												temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, (float)((int)temp.eulerAngles.z - rot_speed));
												transform.rotation = temp;
										} else {
												temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, temp.eulerAngles.z >= ((((int)(temp.eulerAngles.z) / rot_angle) * rot_angle) + (((int)(temp.eulerAngles.z) / rot_angle + 1) * rot_angle)) / 2 ? (((int)(temp.eulerAngles.z) / rot_angle + 1) * rot_angle) : (((int)(temp.eulerAngles.z) / rot_angle) * rot_angle));
												transform.rotation = temp;
										}
								}
						} else {
								sr = renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a = 0.5f;
								sr.color = temp;
						}
				}
	}
}
