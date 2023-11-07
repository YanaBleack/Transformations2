using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _scale;

    private void Update()
    {
        transform.localScale += _scale * Time.deltaTime;
    }
}