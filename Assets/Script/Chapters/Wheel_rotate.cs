using UnityEngine;
using System.Collections;

public class Wheel_rotate : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Application.platform == RuntimePlatform.WP8Player) {
						if (Input.touchCount > 0 && Wheel_Load.rotate == false && name != Wheel_Load.selected.ToString () && Wheel_Load.chapter_selected == false) {
								if (Input.GetTouch (0).phase == TouchPhase.Began) {
										if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
												switch (name) {
												case "1":
														Wheel_Load.selected = 1;
														Wheel_Load.angle = 1.5f;
														break;
												case "2":
														Wheel_Load.selected = 2;
														Wheel_Load.angle = 46.7f;
														break;
												case "3":
														Wheel_Load.selected = 3;
														Wheel_Load.angle = 90.3f;
														break;
												case "4":
														Wheel_Load.selected = 4;
														Wheel_Load.angle = 134.3f;
														break;
												case "5":
														Wheel_Load.selected = 5;
														Wheel_Load.angle = 181.1f;
														break;
												case "6":
														Wheel_Load.selected = 6;
														Wheel_Load.angle = 227.9f;
														break;
												case "7":
														Wheel_Load.selected = 7;
														Wheel_Load.angle = 275.1f;
														break;
												case "8":
														Wheel_Load.selected = 8;
														Wheel_Load.angle = 315.2f;
														break;
												}

												if (GameObject.Find ("Wheel").transform.rotation.eulerAngles.z > Wheel_Load.angle) {
														Wheel_Load.angle += 360;
												}
												if (Mathf.Abs (GameObject.Find ("Wheel").transform.rotation.eulerAngles.z - Wheel_Load.angle) > 190 && Mathf.Abs (GameObject.Find ("Wheel").transform.rotation.eulerAngles.z - Wheel_Load.angle) < 360) {
														Wheel_Load.rotate_dir = false;
														Wheel_Load.angle -= 360;
												} else {
														Wheel_Load.rotate_dir = true;
												}
												Wheel_Load.rotate = true;
										}
								}
						} 
				} else if (Wheel_Load.rotate == false && name != Wheel_Load.selected.ToString () && Wheel_Load.chapter_selected == false) {
						if (Input.GetButton ("Fire1")) {
								if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.mousePosition))) {
										switch (name) {
										case "1":
												Wheel_Load.selected = 1;
												Wheel_Load.angle = 1.5f;
												break;
										case "2":
												Wheel_Load.selected = 2;
												Wheel_Load.angle = 46.7f;
												break;
										case "3":
												Wheel_Load.selected = 3;
												Wheel_Load.angle = 90.3f;
												break;
										case "4":
												Wheel_Load.selected = 4;
												Wheel_Load.angle = 134.3f;
												break;
										case "5":
												Wheel_Load.selected = 5;
												Wheel_Load.angle = 181.1f;
												break;
										case "6":
												Wheel_Load.selected = 6;
												Wheel_Load.angle = 227.9f;
												break;
										case "7":
												Wheel_Load.selected = 7;
												Wheel_Load.angle = 275.1f;
												break;
										case "8":
												Wheel_Load.selected = 8;
												Wheel_Load.angle = 315.2f;
												break;
										}

										if (GameObject.Find ("Wheel").transform.rotation.eulerAngles.z > Wheel_Load.angle) {
												Wheel_Load.angle += 360;
										}
										if (Mathf.Abs (GameObject.Find ("Wheel").transform.rotation.eulerAngles.z - Wheel_Load.angle) > 190 && Mathf.Abs (GameObject.Find ("Wheel").transform.rotation.eulerAngles.z - Wheel_Load.angle) < 360) {
												Wheel_Load.rotate_dir = false;
												Wheel_Load.angle -= 360;
										} else {
												Wheel_Load.rotate_dir = true;
										}
										Wheel_Load.rotate = true;
								}
						}
				}
		}
}
