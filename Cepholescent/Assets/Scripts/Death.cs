using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collisionObject)
	{
		if (collisionObject.gameObject.tag == "Player")
		{
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>().enabled = false;
			ReloadGame();
		}
	}

	private IEnumerator ReloadGame()
	{
		yield return new WaitForSeconds(2);
		Application.LoadLevel(Application.loadedLevel);
	}
}
