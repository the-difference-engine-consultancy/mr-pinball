using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public GameObject gameControllerObject;
	GameController gameController;

	int gameScore = 0;
	public int gameLives = 3;

	public Rigidbody2D rb;
	public GameObject ball;
	public GameObject ballSpawn;
	public int force;

	private AudioSource flipper;
	public AudioClip flipperSound;

	public HingeJoint2D leftFlipper;
	public HingeJoint2D rightFlipper;

	JointMotor2D leftJointMotor;
	JointMotor2D rightJointMotor;

	public Text scoreText;
	public Text livesText;

	public bool isActive = false;

	void Start(){
		gameController = gameControllerObject.GetComponent<GameController> ();
		flipper = GetComponent<AudioSource> ();
	}

	public void AddScore(int plusScore){
		gameScore += plusScore;
		scoreText.text = "Score: " + gameScore;
	}

	public void SubLives(){
		gameLives -= 1;
		livesText.text = "Lives: " + gameLives;
	}

	public void leftButtonDown(){
		leftJointMotor = leftFlipper.motor;

		leftJointMotor.motorSpeed = -500;

		leftFlipper.motor = leftJointMotor;
		flipper.PlayOneShot (flipperSound, 0.5f);
	}

	public void leftButtonUp(){
		leftJointMotor = leftFlipper.motor;

		leftJointMotor.motorSpeed = 500;

		leftFlipper.motor = leftJointMotor;
	}

	public void rightButtonDown(){
		rightJointMotor = rightFlipper.motor;

		rightJointMotor.motorSpeed = 500;

		rightFlipper.motor = rightJointMotor;

		flipper.PlayOneShot (flipperSound, 0.5f);
	}

	public void rightButtonUp(){
		rightJointMotor = rightFlipper.motor;

		rightJointMotor.motorSpeed = -500;

		rightFlipper.motor = rightJointMotor;
	}

	public void launchBall (){
		if (isActive == false) {
			GameObject ballClone = Instantiate (ball) as GameObject;
			ballClone.transform.position = ballSpawn.transform.position;;
			isActive = true;
		}
	}
}
