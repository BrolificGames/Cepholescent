using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player")
		{
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>().enabled = false;
			ReloadGame();
		}
	}

	private IEnumerator ReloadGame()
	{	
		Debug.Log ("reloading");
		yield return new WaitForSeconds(2);
		Application.LoadLevel(Application.loadedLevel);
	}
}
