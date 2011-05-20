using System;
using UnityEngine;

public class ArcSpatialTranslation : IActionOverTime {
    private readonly Transform _objectToTranslate;
    private readonly Vector3 _destination;
    private readonly Vector3 _axis;
    private readonly float _duration;
    private readonly Vector3 _start;
    private readonly Vector3 _fulcrum;
    private float _begin;

    public ArcSpatialTranslation (Transform objectToTranslate, Vector3 destination, Vector3 axis, float duration) {
        _objectToTranslate = objectToTranslate;
        _start = _objectToTranslate.position;
        _destination = destination;
		_axis = axis;
		_fulcrum = Vector3.Lerp (_start, _destination, 0.5F);
        _duration = duration;
    }

    public void Update() {
        if(IsComplete) return;

        if(_begin <= 0)
            _begin = Time.time;
        
        var delta = Mathf.Clamp01 ((Time.time - _begin) / _duration);
	
		IsComplete = (delta == 1);
		Debug.Log(delta);
		
		var c = Mathf.LerpAngle(0, 180, delta);
		Debug.Log(c);
        _objectToTranslate.RotateAround (_fulcrum, _axis, c);
		_objectToTranslate.LookAt(_destination);
    }

    public bool IsComplete { get; private set; }
}

