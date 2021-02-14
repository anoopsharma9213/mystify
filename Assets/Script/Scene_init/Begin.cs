using UnityEngine;
using System.Collections;

public class Begin : MonoBehaviour
{

		public int sequence;
		public float time_delay;
		public float rot_speed;
		public float col_speed;

		// Use this for initialization
		void Start ()
		{
				sequence = 0;
				time_delay = 0.5f;
				col_speed = 0.025f;
		}
	
		// Update is called once per frame
		void Update ()
		{
		switch (Application.loadedLevelName) {
		case "Splash":
			load ();
			break;
		case "Menu":
			load_menu ();
			break;
		case "Chapters":
			load_chapters();
			break;
				}
		}

		void load ()
		{
				switch (sequence) {
				case 0:
						SpriteRenderer sr = GameObject.Find ("background").renderer as SpriteRenderer;
						Color temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("1").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("2").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("3").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						if (temp.a > 1) {
								sequence++;
						}
						break;
				case 1:
						if (time_delay < 0) {
								int stat = 0;
								if (GameObject.Find ("1").transform.rotation.eulerAngles.z > 0 && GameObject.Find ("1").transform.rotation.eulerAngles.z <= 181) {
										GameObject.Find ("1").transform.Rotate (new Vector3 (0, 0, 1), -rot_speed);
								} else {
										stat++;
										GameObject.Find ("1").transform.rotation = new Quaternion (0, 0, 0, 0);
								}
								if (GameObject.Find ("2").transform.rotation.eulerAngles.z < 360 && GameObject.Find ("2").transform.rotation.eulerAngles.z >= 90) {
										GameObject.Find ("2").transform.Rotate (new Vector3 (0, 0, 1), rot_speed * (5.0f / 3.0f));
								} else {
										stat++;
										GameObject.Find ("2").transform.rotation = new Quaternion (0, 0, 0, 0);
								}
								if (GameObject.Find ("3").transform.rotation.eulerAngles.z > 0 && GameObject.Find ("3").transform.rotation.eulerAngles.z <= 181) {
										GameObject.Find ("3").transform.Rotate (new Vector3 (0, 0, 1), -rot_speed);
								} else {
										stat++;
										GameObject.Find ("3").transform.rotation = new Quaternion (0, 0, 0, 0);
								}
								if (stat == 3) {
										sequence++;
										time_delay = 1.0f;
								}
						} else {
								time_delay -= Time.deltaTime;
						}
						break;
				case 2:
						sr = GameObject.Find ("4").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += 0.04f;
						if (temp.a > 1) {
								temp.a = 1.0f;
						}
						sr.color = temp;
						sr = GameObject.Find ("RampageStudios").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += 0.04f;
						if (temp.a > 1) {
								temp.a = 1.0f;
								sequence++;
						}
						sr.color = temp;
						break;
				case 3:
						if (time_delay < 0) {
								sr = GameObject.Find ("RampageStudios").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a -= col_speed;
								sr.color = temp;
								sr = GameObject.Find ("1").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a -= col_speed;
								sr.color = temp;
								sr = GameObject.Find ("2").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a -= col_speed;
								sr.color = temp;
								sr = GameObject.Find ("3").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a -= col_speed;
								sr.color = temp;
								sr = GameObject.Find ("4").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a -= col_speed;
								sr.color = temp;
								if (temp.a < 0) {
										sequence++;
								}
						} else {
								time_delay -= Time.deltaTime;
						}
						break;
				case 4:
						Application.LoadLevel ("Menu");
						break;
				}
		}

		void load_menu ()
		{
				if (sequence == 0) {
						SpriteRenderer sr = GameObject.Find ("play").renderer as SpriteRenderer;
						Color temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("4").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("About").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("About_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("Other").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("Other_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("Rate").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("Rate_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("Settings").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						sr = GameObject.Find ("Settings_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a += col_speed;
						sr.color = temp;
						if (temp.a > 1) {
								sequence++;
						}
				}
		}

	void load_chapters()
	{
		if (sequence == 0) {
			SpriteRenderer sr = GameObject.Find ("next").renderer as SpriteRenderer;
			Color temp = sr.color;
			temp.a += col_speed;
			sr.color = temp;
			sr = GameObject.Find ("outer_circle").renderer as SpriteRenderer;
			temp = sr.color;
			temp.a += col_speed;
			sr.color = temp;
			sr = GameObject.Find ("inner_circle").renderer as SpriteRenderer;
			temp = sr.color;
			temp.a += col_speed;
			sr.color = temp;
			if (temp.a > 1) {
				sequence++;
			}
		}
	}
}
