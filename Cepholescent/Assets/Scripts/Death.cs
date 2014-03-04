using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour 
{
	public GameObject Fader;
	private GameObject player;
	private float positionX;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void FixedUpdate()
	{
		TrackPlayer();
	}

	private void TrackPlayer()
	{
		positionX = player.transform.position.x;
		transform.position = new Vector3(positionX, -7.8f, transform.position.z);
	}

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
		Fader.GetComponent<SceneFadeInOut>().sceneEnding = true;
	}
}
