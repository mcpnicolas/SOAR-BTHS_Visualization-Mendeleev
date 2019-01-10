using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoverInfo : MonoBehaviour {

	public GameObject elementInfo;

	public void enableInfo() {
		elementInfo.SetActive(true);
	}

	public void disableInfo() {
		elementInfo.SetActive(false);
	}
}
