using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour {

	public static int totalUnknowns = 9;
	public GameObject finalMessage;
	void Update() {

		if (Scorekeeper.totalUnknowns == 0) {
			finalMessage.SetActive (true);
		}

	}
}


