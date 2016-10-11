using UnityEngine;
using System.Collections;

public class BumperController : MonoBehaviour {

	GameController gameController;

	public GameObject gameControllerObject;
	public int pointAmount;

	void Start () {
		gameController = gameControllerObject.GetComponent<GameController> ();
	}

	void OnCollisionEnter2D(Collision2D other){
		gameController.AddScore (pointAmount);
	}
}
