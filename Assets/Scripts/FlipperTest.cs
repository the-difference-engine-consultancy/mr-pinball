using UnityEngine;
using System.Collections;

public class FlipperTest : MonoBehaviour {

	public HingeJoint2D left;
	public HingeJoint2D right;

	JointMotor2D leftMotor;
	JointMotor2D rightMotor;

	void Update(){
		if (Input.GetKeyDown ("left")) {
			leftMotor = left.motor;
			leftMotor.motorSpeed = -500;
			left.motor = leftMotor;
		}

		if (Input.GetKeyUp ("left")) {
			leftMotor = left.motor;
			leftMotor.motorSpeed = 500;
			left.motor = leftMotor;
		}

		if (Input.GetKeyDown ("right")) {
			rightMotor = right.motor;
			rightMotor.motorSpeed = 500;
			right.motor = rightMotor;
		}

		if (Input.GetKeyUp ("right")) {
			rightMotor = right.motor;
			rightMotor.motorSpeed = -500;
			right.motor = rightMotor;
		}
	}
}
