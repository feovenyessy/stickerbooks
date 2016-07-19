using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIAR : MonoBehaviour {

	public GameObject obj;

	// Use this for initialization
	void Start () {
		Debug.Log ("start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void launchit() {
		
		GameObject btn = GameObject.Find("Button"); 
		btn.SetActive (false);
		Instantiate(obj);
		Debug.Log ("pressed");
	}

}
