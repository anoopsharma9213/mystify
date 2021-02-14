using UnityEngine;
using System.Collections;

public class Side_Bar : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{

				if (Persistent.music == false) {
						SpriteRenderer sr = GameObject.Find ("music_close").renderer as SpriteRenderer;
						Color temp = sr.color;
						if (temp.a == 0.0f) {
								temp.a = 1.0f;
						} else {
								temp.a = 0.0f;
						}
						sr.color = temp;
				}
				if (Persistent.sound == false) {
						SpriteRenderer sr = GameObject.Find ("sound_close").renderer as SpriteRenderer;
						Color temp = sr.color;
						if (temp.a == 0.0f) {
								temp.a = 1.0f;
						} else {
								temp.a = 0.0f;
						}
						sr.color = temp;
				}
	
		}
	
		// Update is called once per frame
		void Update ()
		{
		}

		void OnMouseUpAsButton ()
		{
				switch (name) {
				case "music":
						SpriteRenderer sr = GameObject.Find ("music_close").renderer as SpriteRenderer;
						Color temp = sr.color;
						if (temp.a == 0.0f) {
								temp.a = 1.0f;
						} else {
								temp.a = 0.0f;
						}
						sr.color = temp;
						break;
				case "sound":
						sr = GameObject.Find ("sound_close").renderer as SpriteRenderer;
						temp = sr.color;
						if (temp.a == 0.0f) {
								temp.a = 1.0f;
						} else {
								temp.a = 0.0f;
						}
						sr.color = temp;
						break;
				}
		}
}