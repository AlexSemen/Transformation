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
    private Transform _transform;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _transform.forward * _speedMove * Time.deltaTime;
        //_rigidbody.AddForce(transform.forward * _speedMove * Time.deltaTime);
    }

    void Update()
    {
        //_transform.position = new Vector3(_transform.position.x + _speedMove * Time.d, _transform.position.y, _transform.position.z);
        _transform.localScale += new Vector3(_speedScale * Time.deltaTime, _speedScale * Time.deltaTime, _speedScale * Time.deltaTime);
        _transform.Rotate(0, _speedTurn * Time.deltaTime, 0);
    }
}
