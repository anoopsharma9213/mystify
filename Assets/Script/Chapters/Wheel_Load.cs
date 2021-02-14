using UnityEngine;
using System.Collections;

public class Wheel_Load : MonoBehaviour
{

		public static bool load = false;
		public static float angle = 1.5f;
		public static bool rotate = false;
		public static bool rotate_dir = true;
		public static int selected = 1;
		public static bool chapter_selected = false;
		public TextMesh chapter_name;
		public static int stage_select = 1;
		public static bool stage_selected = false;


		// Use this for initialization
		void Start ()
		{
				chapter_name.text = "Introduction to" + System.Environment.NewLine + "SuperHeroes";
				load = false;
				angle = 1.5f;
				rotate = false;
				rotate_dir = true;
				selected = 1;
				chapter_selected = false;
				stage_select = 1;
				stage_selected = false;
		}
	
		// Update is called once per frame
		void Update ()
		{
				//Debug.Log (transform.rotation.eulerAngles + " " + " " + Wheel_Load.angle);
				if (Input.GetKey (KeyCode.Escape)) {
						if(chapter_selected == true)
			{
				Back.rev_transition_start = true;
			}else{
						Application.LoadLevel ("Menu");
						load = false;
			}
				} else if (load == false) {
						SpriteRenderer sr = renderer as SpriteRenderer;
						for (int i=1; i<=8; i++) {
								sr = GameObject.Find (i.ToString ()).renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a += 0.05f;
								if (temp.a > 1) {
										temp.a = 1.0f;
										load = true;
								}
								sr.color = temp;
						}
				} else if (rotate == true && chapter_selected == false) {
						if (rotate_dir == false) {
								transform.Rotate (0, 0, -2.0f);
								for (int i=1; i<=8; i++) {
										GameObject.Find (i.ToString ()).transform.Rotate (0, 0, 2.0f);
								}
								if (angle < 0) {
										if (transform.rotation.eulerAngles.z > 358.0f) {
												angle += 360;
										}
								}
								if (transform.rotation.eulerAngles.z < angle + 2.0f) {
										rotate = false;
										switch (selected) {
										case 1:
												chapter_name.text = "Introduction to" + System.Environment.NewLine + "SuperHeroes";
												break;
										case 2:
												chapter_name.text = "Journey to" + System.Environment.NewLine + "Hogwards";
												break;
										case 3:
												chapter_name.text = "?";
												break;
										case 4:
												chapter_name.text = "?";
												break;
										case 5:
												chapter_name.text = "?";
												break;
										case 6:
												chapter_name.text = "?";
												break;
										case 7:
												chapter_name.text = "?";
												break;
										case 8:
												chapter_name.text = "?";
												break;
										}
								}
						} else {
								transform.Rotate (0, 0, 2.0f);
								for (int i=1; i<=8; i++) {
										GameObject.Find (i.ToString ()).transform.Rotate (0, 0, -2.0f);
								}
								if (angle > 360) {
										if (transform.rotation.eulerAngles.z < 2.0f) {
												angle -= 360;
										}
								}
								if (transform.rotation.eulerAngles.z > angle - 2.0f) {
										rotate = false;
										switch (selected) {
										case 1:
												chapter_name.text = "Introduction to" + System.Environment.NewLine + "SuperHeroes";
												break;
										case 2:
												chapter_name.text = "Journey to" + System.Environment.NewLine + "Hogwards";
												break;
										case 3:
												chapter_name.text = "?";
												break;
										case 4:
												chapter_name.text = "?";
												break;
										case 5:
												chapter_name.text = "?";
												break;
										case 6:
												chapter_name.text = "?";
												break;
										case 7:
												chapter_name.text = "?";
												break;
										case 8:
												chapter_name.text = "?";
												break;
										}
								}
						}
						
				} else if (rotate == true && chapter_selected == true && stage_selected == false) {
						if (rotate_dir == false) {
								transform.Rotate (0, 0, -2.0f);
								for (int i=1; i<=8; i++) {
										GameObject.Find (selected.ToString () + i.ToString ()).transform.Rotate (0, 0, 2.0f);
								}
								if (angle < 0) {
										if (transform.rotation.eulerAngles.z > 358.0f) {
												angle += 360;
										}
								}
								if (transform.rotation.eulerAngles.z < angle + 2.0f) {
										rotate = false;
										switch (stage_select) {
										case 1:
												chapter_name.text = "Chapter 1";
												break;
										case 2:
												chapter_name.text = "Chapter 2";
												break;
										case 3:
												chapter_name.text = "?";
												break;
										case 4:
												chapter_name.text = "?";
												break;
										case 5:
												chapter_name.text = "?";
												break;
										case 6:
												chapter_name.text = "?";
												break;
										case 7:
												chapter_name.text = "?";
												break;
										case 8:
												chapter_name.text = "?";
												break;
										}
								}
						} else {
								transform.Rotate (0, 0, 2.0f);
								for (int i=1; i<=8; i++) {
										GameObject.Find (selected.ToString () + i.ToString ()).transform.Rotate (0, 0, -2.0f);
								}
								if (angle > 360) {
										if (transform.rotation.eulerAngles.z < 2.0f) {
												angle -= 360;
										}
								}
								if (transform.rotation.eulerAngles.z > angle - 2.0f) {
										rotate = false;
										switch (stage_select) {
										case 1:
												chapter_name.text = "Chapter 1";
												break;
										case 2:
												chapter_name.text = "Chapter 2";
												break;
										case 3:
												chapter_name.text = "?";
												break;
										case 4:
												chapter_name.text = "?";
												break;
										case 5:
												chapter_name.text = "?";
												break;
										case 6:
												chapter_name.text = "?";
												break;
										case 7:
												chapter_name.text = "?";
												break;
										case 8:
												chapter_name.text = "?";
												break;
										}
								}
						}
			
				}
		}
}
