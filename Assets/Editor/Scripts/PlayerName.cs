using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour {

	public GameObject inputField;
	InputField input;
	string name;
	// Use this for initialization
	void Awake(){

	}

	void Start () {
		input = inputField.GetComponent<InputField> ();
	}

	public void SaveName(){
		name = input.text;
	}
}
