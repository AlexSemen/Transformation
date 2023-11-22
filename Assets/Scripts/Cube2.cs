using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Cube2 : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedTurn;
    [SerializeField] private float _speedScale;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = transform.forward * _speedMove * Time.deltaTime;
    }

    void Update()
    {
        transform.localScale += new Vector3(_speedScale * Time.deltaTime, _speedScale * Time.deltaTime, _speedScale * Time.deltaTime);
        transform.Rotate(0, _speedTurn * Time.deltaTime, 0);
    }
}
