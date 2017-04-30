using UnityEngine;
using UnityEngine.SceneManagement;

[DisallowMultipleComponent]
public class LoadLevelButton : MonoBehaviour {
	public void LoadLevel(int level = 0) {
		SceneManager.LoadScene(level, LoadSceneMode.Single);
	}
}
