using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverUnknown : MonoBehaviour {

	//public GameObject unknown;
	//public GameObject panel;
	private bool floating = false;
	/*
	public void riseUnknown () {
		unknown.transform.Translate (0, 87, 0);
		floating = true;
	}

	public void lowerUnknown() {
		unknown.transform.Translate (0, -87, 0);
		floating = false;
	}
	*/

	public void riseUnknown () {
		if (!floating) {
			gameObject.transform.Translate (0, 110, 0);
			floating = true;
		}
	}

	public void lowerUnknown() {
		if (floating) {
			gameObject.transform.Translate (0, -110, 0);
			floating = false;
		}
	}

	public void Update() {
		if (floating) {
			//panel.SetActive (false);

		} 
		else {
			//panel.SetActive (true);
		}
	}
}

