using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour 
{
	public GameObject Fader;

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player")
		{
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraFollow>().enabled = false;
			StartCoroutine(ReloadGame());
		}
	}

	private IEnumerator ReloadGame()
	{	
		yield return new WaitForSeconds(4);
		Fader.GetComponent<SceneFadeInOut>().EndScene();
	}
}
