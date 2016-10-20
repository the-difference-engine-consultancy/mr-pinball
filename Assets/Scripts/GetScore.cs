﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

//	public string[] scores = new string[10];
	public Text scoreText;
	string scores = "";

	// Use this for initialization
	void Start () {
		StartCoroutine (loadScores());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator loadScores(){

		using (UnityWebRequest request = UnityWebRequest.Get("http://unity-api.herokuapp.com/scores.json"))
		{
			yield return request.Send();

			if (request.isError) // Error
			{
				Debug.Log(request.error);
			}
			else // Success
			{
				JSONObject json = new JSONObject(request.downloadHandler.text);

				if (json.Count <= 10) {
					for (int i = 0; i < json.Count; i++) {
						scores += (json [i] ["name"].ToString()).Substring(1,(json [i] ["name"].ToString()).Length - 2) + ":  " + json [i] ["score"] + "\n";
					}
				} else {
					for (int i = 0; i < 10; i++) {
						scores += (json [i] ["name"].ToString()).Substring(1,(json [i] ["name"].ToString()).Length - 2) + ":  " + json [i] ["score"] + "\n";
					}
				}
			}
		}

		scoreText.text = scores;
	}


}
