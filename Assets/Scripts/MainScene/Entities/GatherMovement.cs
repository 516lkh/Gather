using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GatherMovement : MonoBehaviour
{
    private GatherCharacterController _controller;
    private Animator _animator;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<GatherCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = transform.Find("MainSprite").GetComponent<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
        if(_movementDirection == Vector2.zero) { _animator.SetBool("IsRun", false); }
        else { _animator.SetBool("IsRun", true); }
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }
}
