using UnityEngine;
using System.Collections;

public class Wheel_Rotate_Stage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.WP8Player) {
			if (Input.touchCount > 0 && Wheel_Load.rotate == false && name != Wheel_Load.stage_select.ToString () && Wheel_Load.chapter_selected == true && Wheel_Load.stage_selected==false) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
						if(name == Wheel_Load.selected.ToString()+"1")
						{
							Wheel_Load.stage_select = 1;
							Wheel_Load.angle = 1.5f;
						}else if(name == Wheel_Load.selected.ToString()+"2")
						{
							Wheel_Load.stage_select = 2;
							Wheel_Load.angle = 46.7f;
						}else if(name == Wheel_Load.selected.ToString()+"3")
						{
							Wheel_Load.stage_select = 3;
							Wheel_Load.angle = 90.3f;
						}else if(name == Wheel_Load.selected.ToString()+"4")
						{
							Wheel_Load.stage_select = 4;
							Wheel_Load.angle = 134.3f;
						}else if(name == Wheel_Load.selected.ToString()+"5")
						{
							Wheel_Load.stage_select = 5;
							Wheel_Load.angle = 181.1f;
						}else if(name == Wheel_Load.selected.ToString()+"6")
						{
							Wheel_Load.stage_select = 6;
							Wheel_Load.angle = 227.9f;
						}else if(name == Wheel_Load.selected.ToString()+"7")
						{
							Wheel_Load.stage_select = 7;
							Wheel_Load.angle = 275.1f;
						}else if(name == Wheel_Load.selected.ToString()+"8")
						{
							Wheel_Load.stage_select = 8;
							Wheel_Load.angle = 315.2f;
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
		} else if (Wheel_Load.rotate == false && name != Wheel_Load.stage_select.ToString () && Wheel_Load.chapter_selected == true && Wheel_Load.stage_selected==false) {
			if (Input.GetButton ("Fire1")) {
				if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.mousePosition))) {
					if(name == Wheel_Load.selected.ToString()+"1")
					{
						Wheel_Load.stage_select = 1;
						Wheel_Load.angle = 1.5f;
					}else if(name == Wheel_Load.selected.ToString()+"2")
					{
						Wheel_Load.stage_select = 2;
						Wheel_Load.angle = 46.7f;
					}else if(name == Wheel_Load.selected.ToString()+"3")
					{
						Wheel_Load.stage_select = 3;
						Wheel_Load.angle = 90.3f;
					}else if(name == Wheel_Load.selected.ToString()+"4")
					{
						Wheel_Load.stage_select = 4;
						Wheel_Load.angle = 134.3f;
					}else if(name == Wheel_Load.selected.ToString()+"5")
					{
						Wheel_Load.stage_select = 5;
						Wheel_Load.angle = 181.1f;
					}else if(name == Wheel_Load.selected.ToString()+"6")
					{
						Wheel_Load.stage_select = 6;
						Wheel_Load.angle = 227.9f;
					}else if(name == Wheel_Load.selected.ToString()+"7")
					{
						Wheel_Load.stage_select = 7;
						Wheel_Load.angle = 275.1f;
					}else if(name == Wheel_Load.selected.ToString()+"8")
					{
						Wheel_Load.stage_select = 8;
						Wheel_Load.angle = 315.2f;
					}
//					Debug.Log(Wheel_Load.stage_select+" "+Wheel_Load.angle+" "+Wheel_Load.chapter_selected+" "+Wheel_Load.stage_selected+" "+Wheel_Load.selected);
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
