using UnityEngine;
using System.Collections;

public class BumperController : MonoBehaviour {

	GameController gameController;

	public GameObject gameControllerObject;
	public AudioClip bumperSound;
	private AudioSource bumper;
	public int pointAmount;

	void Start () {
		gameController = gameControllerObject.GetComponent<GameController> ();
		bumper = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter2D(Collision2D other){
		gameController.AddScore (pointAmount);

		if (other.gameObject.tag == "Player") {
			bumper.PlayOneShot(bumperSound,0.5f);
		}
	}
}
