using UnityEngine;
using System.Collections;

public class WWWLeaderboard : MonoBehaviour {

	GameController gameController;
	// Use this for initialization
	void Start () {
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}


	public void SendScore(){
		StartCoroutine (SendScore(gameController.GetScore()));
	}

	IEnumerator SendScore(int score){

		WWWForm form = new WWWForm();
		form.AddField( "score", score );
		form.AddField( "name", "DanChu" );

		WWW postRequest = new WWW( "http://unity-api.herokuapp.com/scores", form );

		yield return postRequest;
		if (!string.IsNullOrEmpty(postRequest.error)) {
			print(postRequest.error);
		}
		else {
			print("Sent Score");
		}

	}
}
