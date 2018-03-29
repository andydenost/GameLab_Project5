using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	public GameObject redcube;
	public GameObject greencube;
	public Text myText;

	// Use this for initialization
	void Start () {
		myText = GameObject.Find ("Text").GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision c){
		if (c.collider.tag=="red"){
			myText.text = "Correct!";
		}else if(c.collider.tag=="green"){
			myText.text = "Wrong!";
		}
	}
}
