using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChage : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _scale;

    private Transform _transform;
    private float _runningTime;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;

            float normalizeRunningTime = _runningTime / _duration;

            _transform.localScale = _scale * normalizeRunningTime;
        }
    }
}
