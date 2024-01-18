using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testi : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpforce;
    [SerializeField] private float _doublejump;
    [SerializeField] private animation animator;
    private bool _onGround;
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.right * _speed);
            animator.PlayMove2();
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.left * _speed);
            animator.PlayMove2();
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(Vector3.forward * _speed);
            animator.PlayMove1();
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rigidbody.AddForce(Vector3.back * _speed);
            animator.PlayMove1();
        }

        if (_onGround && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _jumpforce);
            animator.PlayJump();
        }
        if (_onGround && Input.GetKeyUp(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _doublejump);
            animator.PlayDoubleJump();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "ground")
        {
            _onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "ground")
        {
            _onGround = false;
        }
    }

}