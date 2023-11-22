using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {
        _transform.localScale += new Vector3 (_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);
    }
}
