using UnityEngine;
using System.Collections;

public class BubblesFollow : MonoBehaviour 
{
	public float lifetime;

	private float positionX;
	private float positionY;
	private Transform player;
	
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player").transform.Find("BubbleSpawn");
		Destroy (gameObject, lifetime);
	}
	
	void FixedUpdate()
	{
		TrackPlayer();
	}
	
	private void TrackPlayer()
	{
		positionX = player.position.x;
		positionY = player.position.y;
		
		transform.position = new Vector3(positionX, positionY, transform.position.z);
	}
}
