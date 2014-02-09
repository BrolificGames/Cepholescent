using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	private float positionX;
	private float positionY;
	private GameObject player;

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
		positionY = player.transform.position.y;

		transform.position = new Vector3(positionX, positionY, transform.position.z);
	}
}
