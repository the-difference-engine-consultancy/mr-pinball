using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {
	public string sceneLoad = "";
	GameObject gameController;
	// Update is called once per frame
	void Start(){
		gameController = GameObject.FindGameObjectWithTag ("GameController");
	}

	public void SceneChange () {
		SceneManager.LoadScene (sceneLoad);
		Destroy (gameController.gameObject);
	}
}
