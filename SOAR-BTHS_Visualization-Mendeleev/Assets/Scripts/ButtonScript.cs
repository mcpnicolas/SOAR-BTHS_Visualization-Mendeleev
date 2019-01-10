using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public GameObject myText;
	public GameObject nextText;

	public void changeText () {

		myText.SetActive (false);
		nextText.SetActive (true);
	}

}
