using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangeScript : MonoBehaviour {

	// Use this for initialization

	public Text myText;
	public Button myButton;
	public string newText;

	void Start () {
		//myText = GetComponent<Text> ();
	}
	
	public void NextText() {
		if (myText.text == "The unknown element cards will be located on this side of the screen. To place an unknown and check your answer, click and drag the unknown to an empty space in the periodic table.") {
			myText.gameObject.SetActive (false);
		} else if (myText.text == "Done") {
			myButton.gameObject.SetActive (false);
		} else {
			myText.text = newText;
		}
	}
}