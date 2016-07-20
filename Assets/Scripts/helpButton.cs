using UnityEngine;
using System.Collections;

public class helpButton : MonoBehaviour {
	
	public GameObject hatter;
	public GameObject kilepesGomb;
	public GameObject sugoGomb;
	private Animator anim;

	void Start() {
		anim = GetComponent<Animator> ();
		hatter.SetActive (false);
	}

	public void openHelpPanel() {
		hatter.SetActive (true);
		anim.SetTrigger ("helpOpen");
		kilepesGomb.SetActive (false);
		sugoGomb.SetActive (false);
	}

	public void closeHelpPanel() {
		hatter.SetActive (false);
		anim.SetTrigger ("helpClose");
		kilepesGomb.SetActive (true);
		sugoGomb.SetActive (true);
	}
}
