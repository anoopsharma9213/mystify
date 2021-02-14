using UnityEngine;
using System.Collections;

public class MenuMove : MonoBehaviour {

	int dir;
	float speed = 0.3f;
	bool swipe;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (MenuControl.page == 1) {
						if (Input.touchCount > 0) {

								if (Input.GetTouch (0).phase == TouchPhase.Moved) {
										swipe = true;
										if (!(Input.GetTouch (0).deltaPosition.x < 10 && Input.GetTouch (0).deltaPosition.x > -10) && LevelControl.menu_Tranisition == false) {
												LevelControl.menu_Tranisition = true;
												dir = (Input.GetTouch (0).deltaPosition.x > 0) ? -1 : 1;
										}
								} else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
										if (Input.GetTouch (0).tapCount == 1 && swipe == false) {
												RaycastHit2D hitInfo = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position), Vector2.zero);
												if (hitInfo) {
														MenuControl.transition = 1;
														switch (hitInfo.transform.gameObject.name) {
														case "M1":
																MenuControl.subpage = 1;
																break;
														case "M2":
																MenuControl.subpage = 2;
																break;
														}
												}

										} else if (swipe == true) {
												swipe = false;
										}
								}
						}

						if (LevelControl.menu_Tranisition == true) {
								Vector3 temp = Camera.main.transform.position;

								if (dir == 1 && LevelControl.menu_Position < 4) {
										temp.x = temp.x + speed;
										Camera.main.transform.position = temp;
										if (temp.x >= 12.8f * LevelControl.menu_Position) {
												temp.x = 12.8f * LevelControl.menu_Position;
												Camera.main.transform.position = temp;
												LevelControl.menu_Position++;
												LevelControl.menu_Tranisition = false;
										}
								} else if (dir == -1 && LevelControl.menu_Position > 2) {
										temp.x = temp.x - speed;
										Camera.main.transform.position = temp;
										if (temp.x <= 12.8f * (LevelControl.menu_Position - 2)) {
												temp.x = 12.8f * (LevelControl.menu_Position - 2);
												Camera.main.transform.position = temp;
												LevelControl.menu_Position--;
												LevelControl.menu_Tranisition = false;
										}
								} else {
										LevelControl.menu_Tranisition = false;
								}
						}
				}
		}
}
