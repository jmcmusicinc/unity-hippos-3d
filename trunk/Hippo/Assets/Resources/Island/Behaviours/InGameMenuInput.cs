using UnityEngine;
using System.Collections;

public class InGameMenuInput : MonoBehaviour {
	private bool _isPaused = false;

	private bool _requested = false;
	
	void Update () {
		if( Input.GetKeyDown (KeyCode.Escape)) {
			ShowInGameMenu();
		}
	}
	
	void ShowInGameMenu () {
		_isPaused = !_isPaused;
		Time.timeScale = _isPaused ? 0 :1 ;
	}
}
