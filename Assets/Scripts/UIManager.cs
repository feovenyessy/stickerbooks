using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour {

	public GameObject LoadingObject;

	public static string activeBook = "";

	void Start() {
		LoadingObject.SetActive (false);
	}
	/*
	public void LoadLevel (string nomScene)
	{

		StartCoroutine (LevelCoroutine (nomScene));
	}


	IEnumerator LevelCoroutine (System.String nomScene)
	{
		LoadingScene.SetActive (true);

		AsyncOperation async = SceneManager.LoadSceneAsync(nomScene);

		Debug.Log(async.progress);

		LoadingBar.fillAmount = async.progress;
		Debug.Log(async.progress);
		textPercentage.text = async.progress + "%";

		yield return async;

	}
	*/

	public void start_baby() {
		/*
		GameObject canvas = GameObject.Find("debugcanvas");
		Text[] textValue = canvas.GetComponentsInChildren<Text>();
		textValue[0].text = "Loadinghey";
		*/
		//LoadLevel("babyanimals");
		//UIManager.activeBook = "babyanimals";
		LoadingObject.SetActive (true);
		SceneManager.LoadSceneAsync("baby");
	}

	public void start_dino() {
		//UIManager.activeBook = "dinosaurs";
		LoadingObject.SetActive (true);
		SceneManager.LoadSceneAsync("dino");
	}

	public void start_things() {
		//UIManager.activeBook = "thingsthatgo";
		LoadingObject.SetActive (true);
		SceneManager.LoadSceneAsync("things");
	}

	public void start_home() {
		//UIManager.activeBook = "thingsthatgo";
		SceneManager.LoadSceneAsync("startup");
	}

	public void exit_app() {
		//UIManager.activeBook = "thingsthatgo";
		Application.Quit();
	}

}
