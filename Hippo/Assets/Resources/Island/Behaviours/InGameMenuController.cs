using UnityEngine;
using System.Collections;

public class InGameMenuController : MonoBehaviour {
	private bool _isPaused = false;

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
