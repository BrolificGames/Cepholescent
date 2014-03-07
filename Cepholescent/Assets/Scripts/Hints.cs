using UnityEngine;
using System.Collections;

public class Hints : MonoBehaviour {
	public bool shown = false;
	public string hintText;
	public GUIText hint;
	public bool suspend;

	private bool _keyPressed = false;

	void Start()
	{
		hint.text = "";
	}

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

		if (suspend) {
			while (!Input.GetKeyUp("return"))
			{
				Time.timeScale = 0f;
				yield return null;
			}
		}
		else {
			yield return new WaitForSeconds(4);
		}

		Time.timeScale = 1f;
		closeDialog();
		yield return null;
	}

	private void openDialog()
	{
		hint.text = hintText;
	}

	private void closeDialog()
	{
		hint.text = "";
	}
}