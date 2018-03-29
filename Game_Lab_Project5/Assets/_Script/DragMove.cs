using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragMove : MonoBehaviour {

	Vector3 screenPosition;
	Vector3 offset;
	// Use this for initialization
	void Start ()
	{
		//StartCoroutine(OnMouseDown());
	}

	/*IEnumerator OnMouseDown()//version 1
	{
		Vector3 screenPosition = Camera.main.WorldToScreenPoint(this.transform.position);
		Vector3 offset = this.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
		while (Input.GetMouseButton(0))
		{
			Vector3 currentRealPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z)) + offset;
			this.transform.position = currentRealPos;
			yield return new WaitForFixedUpdate(); 
		}
	}*/

	/*void Update() {
		Vector3 screenPosition = Camera.main.WorldToScreenPoint(this.transform.position);
		if (Input.GetMouseButton(0)) { //version 2
			Debug.Log ("???");
			this.transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
		}
	}*/

//version 3
	void OnMouseDown(){
		screenPosition = Camera.main.WorldToScreenPoint(this.transform.position);
		offset = this.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z));
	}

	void OnMouseDrag(){
		Vector3 currentRealPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPosition.z)) + offset;
		this.transform.position = currentRealPos;
	}
}
