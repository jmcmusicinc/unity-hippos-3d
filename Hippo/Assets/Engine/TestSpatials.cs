using UnityEngine;
using System.Collections;
using Engine;

public class TestSpatials : MonoBehaviour {
	
	public Transform A;
	
	public Transform B;
	
	public float Duration;
	
	public enum ModeSettings { Arc, Linear }
	
	public ModeSettings TranslateMode;
	
	private IActionOverTime _spatial;
	
	IEnumerator Start () {
		yield return new WaitForSeconds(2);
		if(this.TranslateMode == TestSpatials.ModeSettings.Linear)
			_spatial = new LinearSpatialTranslation(A, B.position, this.Duration);
		else
			_spatial = new ArcSpatialTranslation(A, B.position, Vector3.up, this.Duration);
	}
	
	void Update () {
		if(_spatial != null)
			_spatial.Update();
	}
}
