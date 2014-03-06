using UnityEngine;
using System.Collections;

public class Hints : MonoBehaviour {
	public bool shown = false;
	private bool _keyPressed = false;

	void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "Player" && shown == false)
		{
			shown = true;
			StartCoroutine(showHint());
		}
	}

	private IEnumerator showHint()
	{
		openDialog();

		while (!Input.GetKeyUp("return"))
		{
			Time.timeScale = 0f;
			yield return null;
		}

		Time.timeScale = 1f;
		closeDialog();
		yield return null;
	}

	private void openDialog()
	{
		Debug.Log ("open dialog");
	}

	private void closeDialog()
	{
		Debug.Log ("hide hint");
	}
}