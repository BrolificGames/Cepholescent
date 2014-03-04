using UnityEngine;
using System.Collections;

public class Hints : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player")
		{
			Debug.Log ("show hint");
		}
	}
}
