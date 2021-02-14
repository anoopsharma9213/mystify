using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour
{

		bool transition_start;
		int sequence = 0;
		float time_delay = 1.0f;

		// Use this for initialization
		void Start ()
		{
				transition_start = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
		if (transition_start == false) {
						if (Application.platform == RuntimePlatform.WP8Player) {
								if (Input.touchCount > 0 && Wheel_Load.rotate == false) {
										if (Input.GetTouch (0).phase == TouchPhase.Began) {
												if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
														if (Persistent.chapter [Wheel_Load.selected - 1] == true && Wheel_Load.chapter_selected == false) {
																Wheel_Load.chapter_selected = true;
																transition_start = true;
														} else {
																Application.LoadLevel ("Test");
														}
												}
										}
								}
						} else {
								if (Input.GetButton ("Fire1") && Wheel_Load.rotate == false) {
										if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.mousePosition))) {
												if (Persistent.chapter [Wheel_Load.selected - 1] == true && Wheel_Load.chapter_selected == false) {
														Wheel_Load.chapter_selected = true;
														transition_start = true;
												} else {
														Application.LoadLevel ("Test");
												}
										}
								}
						}
				}else if (transition_start == true) {
						switch (sequence) {
						case 0:
								SpriteRenderer sr = renderer as SpriteRenderer;
								for (int i=1; i<=8; i++) {
										sr = GameObject.Find (i.ToString ()).renderer as SpriteRenderer;
										Color temp = sr.color;
										temp.a -= 0.05f;
										if (temp.a < 0) {
												temp.a = 0.0f;
												sequence = 1;
										}
										sr.color = temp;
								}
								break;
						case 1:
								if (time_delay < 0 && GameObject.Find ("Wheel").transform.rotation.eulerAngles.z < 10.0f) {
										Quaternion pos = GameObject.Find ("Wheel").transform.rotation;
										pos.eulerAngles = new Vector3 (0, 0, 1.5f);
										GameObject.Find ("Wheel").transform.rotation = pos;
										sequence++;
								} else {
										GameObject.Find ("Wheel").transform.Rotate (0, 0, 10.0f);
										time_delay -= Time.deltaTime;
								}
								break;
						case 2:
								sr = renderer as SpriteRenderer;
								for (int i=1; i<=8; i++) {
										Vector3 temp_pos = GameObject.Find (Wheel_Load.selected.ToString () + i.ToString ()).transform.position;
										temp_pos.z = -1.5f;
										GameObject.Find (Wheel_Load.selected.ToString () + i.ToString ()).transform.position = temp_pos;
										sr = GameObject.Find (Wheel_Load.selected.ToString () + i.ToString ()).renderer as SpriteRenderer;
										Color temp = sr.color;
										temp.a += 0.05f;
										if (temp.a > 1) {
												temp.a = 1.0f;
												transition_start = false;
												sequence = 0;
						time_delay = 1.0f;
//						Wheel_Load.angle = 1.5f;
//						Wheel_Load.rotate = false; 
//						
//						Wheel_Load.rotate_dir = true;
//						Wheel_Load.stage_select = 1;
//						Wheel_Load.stage_selected = false;
										}
										sr.color = temp;
								}
								break;
						}
				}
		}
}
