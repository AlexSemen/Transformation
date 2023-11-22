using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
