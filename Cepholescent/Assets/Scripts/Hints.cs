using UnityEngine;
using System.Collections;

public class Hints : MonoBehaviour {
	public bool shown = false;

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player" && shown == false)
		{
			Debug.Log ("showing hint");
			shown = true;
		}
	}
}
