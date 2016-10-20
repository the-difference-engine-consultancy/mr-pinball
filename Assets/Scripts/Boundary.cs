using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour {

	//Game controller object set in UnityEngine.
	public GameObject gameControllerObject;
	GameController gameController;

	void Start(){
		gameController = gameControllerObject.GetComponent<GameController> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		//Destroys the object that collides with the object with this script.
		Destroy (other.gameObject);

		gameController.SubLives ();

		//Sets variable isActive from the GameController false to allow ball to be launched again.
		gameController.isActive = false;

		//Changes scene to "Restart" scene.
		if (gameController.gameLives < 1) {
			SceneManager.LoadScene ("UploadScore");
		}
	}
}
