using UnityEngine;
using System.Collections;

public class Motion : MonoBehaviour {

	public static bool complete = false;
	bool pause = false, next = false;
	public static int level;
	public float speed;
	public float delay = 2.0f;

	// Use this for initialization
	void Start () {
		level = 1;
		speed = 0.3f;
	}
	
	// Update is called once per frame
	void Update () {
				if (MenuControl.page == 3) {
						if (pause == false) {
								int flag = 0;
								foreach (Transform t in GameObject.Find ("C"+MenuControl.subpage).transform.FindChild("L"+level.ToString()).transform) {
										if ((int)t.rotation.eulerAngles.z % 360 != 0) {
												flag++;
										}
								}
								if (flag == 0) {
										if (level == 9) {
												level = 1;
												MenuControl.page = 2;
												MenuControl.subpage = 2;
												Vector3 temp = Camera.main.transform.position;
												temp.x = temp.x + 12.8f;
												temp.y = 10;
												Camera.main.transform.position = temp;
										} else {
												complete = true;
												if(delay == 0)
												{	
													delay = 10;
													GameObject.Find ("InterLevel").transform.position = new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y,-9);
													pause = true;
												}else {
													delay -= Time.deltaTime;
												}
										}
								}
						} else if (pause == true && next == false) {
								if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
										RaycastHit2D hitInfo = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position), Vector2.zero);
										if (hitInfo) {
												if (hitInfo.transform.gameObject.name == "Home") {
														Vector3 temp = Camera.main.transform.position;
														temp.y = 10;
														MenuControl.page = 2;
														Camera.main.transform.position = temp;
														GameObject.Find ("InterLevel").transform.position = new Vector3 (0, -10, -9);
														pause = false;
														complete = false;
												} else if (hitInfo.transform.gameObject.name == "Next") {
														next = true;
												}
										}
								}
						} else if (next == true) {
								Vector3 temp = Camera.main.transform.position;
								temp.y = temp.y + speed;
								Camera.main.transform.position = temp;
								if (temp.y >= GameObject.Find ("L" + (level + 1).ToString ()).transform.position.y) {
										temp.y = GameObject.Find ("L" + (level + 1).ToString ()).transform.position.y;
										Camera.main.transform.position = temp;
										level++;
										next = false;
										pause = false;
										complete = false;
										GameObject.Find ("InterLevel").transform.position = new Vector3 (0, -10, -9);
								}
						}
				}
	}
}