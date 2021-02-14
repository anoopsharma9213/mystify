using UnityEngine;
using System.Collections;

public class LevelBegin : MonoBehaviour {

	public static bool play = false;
	int sequence = 0;
	bool end;
	public float time_delay = 3.0f;
	public float time_limit;
	public float[] deg = new float[4];
	//public TextMesh test;

	// Use this for initialization
	void Start () {
		play = false;
		time_limit = 0.3f;
		end = false;
		Random.seed = 193;//786;//118;//42;
		for (int i=0; i<4; i++) {
			deg[i] = (float)(Random.Range(-15,15));
				}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
						Application.LoadLevel("Chapters");
				} else {
						if (play == false && end == false) {
								time_delay -= Time.deltaTime;
								if (time_delay < 1.8f && time_delay > 0) {
										for (int i=1; i<=4; i++) {
												GameObject.Find (i.ToString ()).transform.Rotate (new Vector3 (0, 0, 1), deg [i - 1]);
										}
								} else if (time_delay < 0) {
										play = true;
										time_delay = 10.0f;
								}
						} else if (play == false && end == true) {
								level_end();
						} else {
								int flag = 0;
								//test.text = " ";
								for (int i=0; i<4; i++) {
										//test.text += GameObject.Find ((i + 1).ToString ()).transform.rotation.eulerAngles.z.ToString();
										//test.text += "  ";
										if (GameObject.Find ((i + 1).ToString ()).transform.rotation.eulerAngles.z != 0) {
												flag++;
										}
								}
								if (flag == 0) {
										play = false;
										end = true;
										time_delay = time_limit;
								}
						}
				}
	}

	void level_end()
	{
				SpriteRenderer sr;
				Color temp = new Color ();
				switch (sequence) {
				case 0:
						time_delay -= Time.deltaTime;
						if (time_delay < 0) {
								time_delay = time_limit;
								sequence++;
						} else {
								sr = GameObject.Find (Change.ring.ToString ()).renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 0.5f;
								sr.color = temp;
						}
						break;
				case 1:
						time_delay -= Time.deltaTime;
						if (time_delay < 0) {
								time_delay = time_limit;
								sequence++;
						} else {
								sr = GameObject.Find ("1").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
						}
						break;
				case 2:
						time_delay -= Time.deltaTime;
						if (time_delay < 0) {
								time_delay = time_limit;
								sequence++;
						} else {
								sr = GameObject.Find ("2").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
						}
						break;
				case 3:
						time_delay -= Time.deltaTime;
						if (time_delay < 0) {
								time_delay = time_limit;
								sequence++;
						} else {
								sr = GameObject.Find ("3").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
						}
						break;
				case 4:
						time_delay -= Time.deltaTime;
						if (time_delay < 0) {
								time_delay = time_limit;
								sequence++;
						} else {
								sr = GameObject.Find ("4").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
						}
						break;
				case 5:
						sr = GameObject.Find ("black_bg").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a = 0.0f;
						sr.color = temp;
						sequence++;
						break;
				case 6:
						sr = GameObject.Find ("b_inner").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a = 0.0f;
						sr.color = temp;
						sequence++;
						break;
				case 7:
						sr = GameObject.Find ("b_outer").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a = 0.0f;
						sr.color = temp;
						sequence++;
						break;
				case 8:
						sr = GameObject.Find ("b_swipe").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a = 0.0f;
						sr.color = temp;
						sequence++;
						break;
				case 9:
						int flag = 0;
						for (int i=1; i<=4; i++) {
								GameObject.Find (i.ToString ()).transform.position = new Vector3 (GameObject.Find (i.ToString ()).transform.position.x + 0.15f, GameObject.Find (i.ToString ()).transform.position.y);
								if (GameObject.Find (i.ToString ()).transform.position.x >= 0) {
										flag++;
										GameObject.Find (i.ToString ()).transform.position = new Vector3 (0, GameObject.Find (i.ToString ()).transform.position.y);
								}
						}
						if (flag != 0) {
								sequence++;
						}
						break;
				case 10:
						sr = GameObject.Find ("0").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += 0.07f;
						if (temp.a > 1.0f) {
								temp.a = 1.0f;
								sequence++;
						}
						sr.color = temp;
						break;
				}
	}
}
