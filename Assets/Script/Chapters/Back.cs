using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	public static bool rev_transition_start = false;
	int sequence = 0;
	float time_delay = 1.0f;
	
	// Use this for initialization
	void Start ()
	{
		rev_transition_start = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (rev_transition_start == true) {
			switch (sequence) {
			case 0:
				SpriteRenderer sr = renderer as SpriteRenderer;
				for (int i=1; i<=8; i++) {
					Vector3 temp_pos = GameObject.Find (Wheel_Load.selected.ToString () + i.ToString ()).transform.position;
					temp_pos.z = 1;
					GameObject.Find (Wheel_Load.selected.ToString () + i.ToString ()).transform.position = temp_pos;
					sr = GameObject.Find (Wheel_Load.selected.ToString () + i.ToString ()).renderer as SpriteRenderer;
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
					sr = GameObject.Find (i.ToString ()).renderer as SpriteRenderer;
					Color temp = sr.color;
					temp.a += 0.05f;
					if (temp.a > 1) {
						temp.a = 1.0f;
						rev_transition_start = false;
						Wheel_Load.chapter_selected = false;
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
