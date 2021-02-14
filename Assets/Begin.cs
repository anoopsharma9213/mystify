using UnityEngine;
using System.Collections;

public class Begin : MonoBehaviour {

	public int begin;
	public float rot_speed, col_speed;

	// Use this for initialization
	void Start () {
		begin = 0;
	}
	
	// Update is called once per frame
	void Update () {

		GameObject p1 = GameObject.Find ("1");
		GameObject p2 = GameObject.Find ("2");
		GameObject p3 = GameObject.Find ("3");
		GameObject l = GameObject.Find ("Logo");
		GameObject play = GameObject.Find ("play");
		GameObject inner = GameObject.Find ("inner_ring");
		GameObject outer = GameObject.Find ("outer_ring");
		Color temp = new Color ();

		if (begin < 1) {
						SpriteRenderer sr = p1.renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						SpriteRenderer sr1 = p2.renderer as SpriteRenderer;
						temp = sr1.color;
						temp.a += col_speed;
						sr1.color = temp;
						SpriteRenderer sr2 = p3.renderer as SpriteRenderer;
						temp = sr2.color;
						temp.a += col_speed;
						sr2.color = temp;
						SpriteRenderer sr3 = l.renderer as SpriteRenderer;
						temp = sr3.color;
						temp.a += col_speed;
						sr3.color = temp;
						if (temp.a > 1.0f) {
								begin++;
						}
				} else if (begin < 2) {
						int stat = 0;
						if (p1.transform.rotation.eulerAngles.z > 0 && p1.transform.rotation.eulerAngles.z <= 181) {
								p1.transform.Rotate (new Vector3 (0, 0, 1), -rot_speed);
						} else {
								stat++;
								p1.transform.rotation = new Quaternion (0, 0, 0, 0);
						}
						if (p2.transform.rotation.eulerAngles.z < 360 && p2.transform.rotation.eulerAngles.z >= 90) {
								p2.transform.Rotate (new Vector3 (0, 0, 1), rot_speed * (5.0f / 3.0f));
						} else {
								stat++;
								p2.transform.rotation = new Quaternion (0, 0, 0, 0);
						}
						if (p3.transform.rotation.eulerAngles.z > 0 && p3.transform.rotation.eulerAngles.z <= 181) {
								p3.transform.Rotate (new Vector3 (0, 0, 1), -rot_speed);
						} else {
								stat++;
								p3.transform.rotation = new Quaternion (0, 0, 0, 0);
						}
						if (stat == 3) {
								begin++;
						}
				} else if (begin < 8) {
						begin++;
				} else if (begin < 9) {
						SpriteRenderer sr = p1.renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= col_speed;
						sr.color = temp;
						SpriteRenderer sr1 = p2.renderer as SpriteRenderer;
						temp = sr1.color;
						temp.a -= col_speed;
						sr1.color = temp;
						SpriteRenderer sr2 = p3.renderer as SpriteRenderer;
						temp = sr2.color;
						temp.a -= col_speed;
						sr2.color = temp;
						SpriteRenderer sr3 = l.renderer as SpriteRenderer;
						temp = sr3.color;
						temp.a -= col_speed;
						sr3.color = temp;
						if (temp.a <= 0f) {
								begin++;
						}
				} else if (begin < 10) {
						SpriteRenderer sr = play.renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						SpriteRenderer sr1 = outer.renderer as SpriteRenderer;
						temp = sr1.color;
						temp.a += col_speed;
						sr1.color = temp;
						SpriteRenderer sr2 = inner.renderer as SpriteRenderer;
						temp = sr2.color;
						temp.a += col_speed;
						sr2.color = temp;
						if (temp.a > 1.0f) {
								begin++;
						}
				}
	}
}
