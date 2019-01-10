using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler {

	private Vector2 startPos;

	public void OnDrag(PointerEventData eventData) {

		gameObject.transform.position = Input.mousePosition;
	}

	public void OnEndDrag(PointerEventData eventData) {

		gameObject.transform.position = startPos;
	}

	// Use this for initialization
	void Start () {
		startPos = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
