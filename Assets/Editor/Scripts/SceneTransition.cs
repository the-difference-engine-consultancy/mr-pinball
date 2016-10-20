using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {
	public string sceneLoad = "";
	// Update is called once per frame
	public void SceneChange () {
		SceneManager.LoadScene (sceneLoad);
	}
}
