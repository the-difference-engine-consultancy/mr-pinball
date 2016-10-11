using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour {

	public GameObject gameControllerObject;
	GameController gameController;

	void Start(){
		gameController = gameControllerObject.GetComponent<GameController> ();
	}

	void OnTriggerEnter2D(Collider2D other){

		Destroy (other.gameObject);
		gameController.SubLives ();
		gameController.isActive = false;
		if (gameController.gameLives < 1) {
			SceneManager.LoadScene ("Restart");
		}
	}
}
