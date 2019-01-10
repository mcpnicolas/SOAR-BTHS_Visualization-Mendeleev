using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckUnknown : MonoBehaviour {

	public string answer;
	public InputField input;

	public GameObject element;
	public GameObject unknown;
	public GameObject panel;
	public GameObject correctMessage;
	public GameObject wrongMessage;


	public void checkAnswer() {
		if (input.text == answer) {
			// correct
			// Debug.Log("correct");
			correctMessage.SetActive(true);

			element.SetActive(true);
			unknown.SetActive (false);
			panel.SetActive (false);
			Scorekeeper.totalUnknowns--;
			//gameObject.SetActive (false);

			StartCoroutine ("WaitHide", correctMessage);

		} else {
			// wrong
			// Debug.Log("wrong");
			input.text = "";
			wrongMessage.SetActive (true);
			StartCoroutine ("WaitHide", wrongMessage);

		}
	}

	IEnumerator WaitHide(GameObject message)
	{  
		yield return (new WaitForSeconds(2));
		message.SetActive (false);

		if (message == correctMessage) {
			gameObject.SetActive (false);
		}
	}
}
