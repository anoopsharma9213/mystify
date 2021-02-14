using UnityEngine;
using System.Collections;

public class Button_action : MonoBehaviour
{

		//float time_delay;
		public static int action = 0;
		public bool side_bar_show = false;

		// Use this for initialization
		void Start ()
		{
				//time_delay = 1.0f;
				action = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKey (KeyCode.Escape) && name == "glow") {
						if (side_bar_show == true) {
								action = 3;
						} else {
								Application.Quit ();
						}
				}
				switch (action) {
				case 1:
						play_transition ();
						break;
				case 2:
						display_SideBar ();
						break;
				case 3:
						hide_SideBar ();
						break;
				}
		}

		void OnMouseUpAsButton ()
		{
				if (action == 0) {
						switch (name) {
						case "glow":
								action = 1;
								SpriteRenderer sr = renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a = 0.0f;
								sr.color = temp;
								Play_Glow.run = false;
								break;
						case "Settings":
								action = 2;
								break;
						case "Rate":

								break;
						case "Other":
								switch (Application.platform) {
								case RuntimePlatform.WP8Player:
										Application.OpenURL ("zune:search?publisher=RAMPAGE studios");
										break;
								default:
										Application.OpenURL ("www.rampagestudios.in");
										break;
								}
								break;
						}
				} else if (action == 2) {
						action = 3;
				}
		}

		void play_transition ()
		{
				float color_delay = 0.025f;
				if (name == "glow") {
						SpriteRenderer sr = GameObject.Find ("play").renderer as SpriteRenderer;
						Color temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("4").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("About").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("About_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("Other").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("Other_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("Rate").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("Rate_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("Settings").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						sr = GameObject.Find ("Settings_symbol").renderer as SpriteRenderer;
						temp = sr.color;
						temp.a -= color_delay;
						sr.color = temp;
						if (temp.a < 0) {
								Application.LoadLevel ("Chapters");
						}
				}
		}

		void display_SideBar ()
		{
				if (name == "glow") {
						if (side_bar_show == false) {
								GameObject.Find ("Side_Bar").transform.position = new Vector3 (GameObject.Find ("Side_Bar").transform.position.x - 0.15f, 0, -3);
								if (GameObject.Find ("Side_Bar").transform.position.x < 0) {
										GameObject.Find ("Side_Bar").transform.position = new Vector3 (0, 0, -3);
										side_bar_show = true;
								}
						}
				}
		}

		void hide_SideBar ()
		{
				if (name == "glow") {
						GameObject.Find ("Side_Bar").transform.position = new Vector3 (GameObject.Find ("Side_Bar").transform.position.x + 0.15f, 0, -3);
						if (GameObject.Find ("Side_Bar").transform.position.x > 2.3f) {
								GameObject.Find ("Side_Bar").transform.position = new Vector3 (2.3f, 0, -3);
								side_bar_show = false;
								action = 0;
						}
				}
		}
}
