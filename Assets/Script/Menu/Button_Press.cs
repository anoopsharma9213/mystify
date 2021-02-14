using UnityEngine;
using System.Collections;

public class Button_Press : MonoBehaviour
{

		bool glow = false;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.WP8Player) {
						if (Input.touchCount > 0) {
								if (Input.GetTouch (0).phase == TouchPhase.Began) {
										if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position))) {
												glow = true;
												SpriteRenderer sr = renderer as SpriteRenderer;
												Color temp = sr.color;
												temp.a = 0.7f;
												sr.color = temp;
												sr = GameObject.Find (name + "_symbol").renderer as SpriteRenderer;
												temp = sr.color;
												temp.a = 0.7f;
												sr.color = temp;
										} else if (glow == true) {
												glow = false;
												SpriteRenderer sr = renderer as SpriteRenderer;
												Color temp = sr.color;
												temp.a = 1.0f;
												sr.color = temp;
												sr = GameObject.Find (name + "_symbol").renderer as SpriteRenderer;
												temp = sr.color;
												temp.a = 1.0f;
												sr.color = temp;
										}
								} else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
										if (glow == true) {
												glow = false;
												SpriteRenderer sr = renderer as SpriteRenderer;
												Color temp = sr.color;
												temp.a = 1.0f;
												sr.color = temp;
												sr = GameObject.Find (name + "_symbol").renderer as SpriteRenderer;
												temp = sr.color;
												temp.a = 1.0f;
												sr.color = temp;
										}
								}
						}
				} else if (Input.GetButton ("Fire1")) {
						if (collider2D == Physics2D.OverlapPoint (Camera.main.ScreenToWorldPoint (Input.mousePosition))) {
								glow = true;
								SpriteRenderer sr = renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a = 0.7f;
								sr.color = temp;
								sr = GameObject.Find (name + "_symbol").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 0.7f;
								sr.color = temp;
						} else if (glow == true) {
								glow = false;
								SpriteRenderer sr = renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
								sr = GameObject.Find (name + "_symbol").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
						}
				} else {
						if (glow == true) {
								glow = false;
								SpriteRenderer sr = renderer as SpriteRenderer;
								Color temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
								sr = GameObject.Find (name + "_symbol").renderer as SpriteRenderer;
								temp = sr.color;
								temp.a = 1.0f;
								sr.color = temp;
						}
				}
		}
}
