using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour 
{
	public float floatSpeed = 2.0f;
	public float offset = 2.0f;

	private Vector3 pointA;
	private Vector3 pointB;

	IEnumerator Start()
	{
		pointA = transform.position;
		pointB = new Vector3(pointA.x, pointA.y + offset);

		while (true)
		{
			float location = Mathf.PingPong(Time.time * floatSpeed, 1);
			transform.position = Vector3.Lerp(pointA, pointB, location);
			yield return null;
		}
	}
}
