using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherAim : MonoBehaviour
{
    private GatherCharacterController _controller;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _controller = GetComponent<GatherCharacterController>();
        _spriteRenderer = transform.Find("MainSprite").GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _controller.OnLookEvent += Look;
    }

    private void Look(Vector2 direction)
    {
        ApplyLook(direction);
    }

    private void ApplyLook(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _spriteRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
