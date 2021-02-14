using UnityEngine;
using System.Collections;

public class MenuControl : MonoBehaviour {

	public static int page = 0;
	public static int subpage = 0;
	public static int transition = 0;
	float speed = 0.3f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
				if (transition == 0) {
						if (Input.GetKey (KeyCode.Escape) && name == "Main Camera") {
								transition = -1;
						} else if (name == "Main Camera") {
								if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
										RaycastHit2D hitInfo = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position), Vector2.zero);
										if (hitInfo) {
												switch (hitInfo.transform.gameObject.name) {
												case "S1":
														Vector3 temp = Camera.main.transform.position;
														temp.y = 20;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S2":
														temp = Camera.main.transform.position;
														temp.y = 30;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S3":
														temp = Camera.main.transform.position;
														temp.y = 40;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S4":
														temp = Camera.main.transform.position;
														temp.y = 50;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S5":
														temp = Camera.main.transform.position;
														temp.y = 60;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S6":
														temp = Camera.main.transform.position;
														temp.y = 70;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S7":
														temp = Camera.main.transform.position;
														temp.y = 80;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S8":
														temp = Camera.main.transform.position;
														temp.y = 90;
														page = 3;
														Camera.main.transform.position = temp;
														break;
												case "S9":
														temp = Camera.main.transform.position;
														temp.y = 100;
														page = 3;
														Camera.main.transform.position = temp;
														break;

												}
										}
								}
						}
						if (name == "Start") {
								if (Input.GetTouch (0).phase == TouchPhase.Ended) {
										if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
												transition = 1;
										}
								}
						}
				} else if (transition == 1 && name == "Main Camera") {
						switch (page) {
						case 0:
								Vector3 temp = Camera.main.transform.position;
								temp.x = temp.x + speed;
								Camera.main.transform.position = temp;
								if (temp.x >= 12.8f) {
										temp.x = 12.8f;
										Camera.main.transform.position = temp;
										page = 1;
										transition = 0;
								}
								break;
						case 1:
								temp = Camera.main.transform.position;
								temp.y = temp.y + speed;
								Camera.main.transform.position = temp;
								if (temp.y >= 10) {
										temp.y = 10;
										Camera.main.transform.position = temp;
										page = 2;
										transition = 0;
								}
								break;
						}
				} else if (transition == -1 && name == "Main Camera") {
						switch (page) {
						case 0:
								Application.Quit ();
								break;
						case 1:
								Vector3 temp = Camera.main.transform.position;
								temp.x = temp.x - speed;
								Camera.main.transform.position = temp;
								if (temp.x < 0) {
										temp.x = 0;
										Camera.main.transform.position = temp;
										page = 0;
										transition = 0;
								}
								break;
						case 2:
								temp = Camera.main.transform.position;
								temp.y = temp.y - speed;
								Camera.main.transform.position = temp;
								if (temp.y < 0) {
										temp.y = 0;
										Camera.main.transform.position = temp;
										page = 1;
										transition = 0;
								}
								break;
						case 3:
								temp = Camera.main.transform.position;
								temp.y = 10;
								page = 2;
								transition = 0;
								Camera.main.transform.position = temp;
								break;
						}
				}
	}
}
