using System;
using UnityEngine;

public class LinearSpatialTranslation : IActionOverTime {
    private readonly Transform _objectToTranslate;
    private readonly Vector3 _destination;
    private readonly float _duration;
    private readonly Vector3 _start;
    private float _begin;

    public LinearSpatialTranslation (Transform objectToTranslate, Vector3 destination, float duration) {
        _objectToTranslate = objectToTranslate;
        _start = _objectToTranslate.position;
        _destination = destination;
        _duration = duration;
    }

    public void Update() {
        if(IsComplete) return;

        if(_begin <= 0)
            _begin = Time.time;
        
        var delta = Mathf.Clamp01 ((Time.time - _begin) / _duration);
	
		IsComplete = (delta == 1);
	
        _objectToTranslate.position = Vector3.Lerp (_start, _destination, delta);
    }

    public bool IsComplete { get; private set; }
}

