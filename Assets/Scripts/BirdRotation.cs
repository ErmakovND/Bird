using System;
using UnityEngine;

public class BirdRotation : MonoBehaviour
{
    private float _speed = 300;

    private Rigidbody2D _rb;
    private float _flapHeight;
    private float _angle;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _flapHeight = transform.position.y;
        }

        var direction = _rb.velocity.y;

        if (direction > 0 && _angle > 30) return;
        if (direction < 0 && (_angle < -60 || transform.position.y > _flapHeight)) return;

        Rotate(direction);
    }

    private void Rotate(float direction)
    {
        var deg = _speed * Time.deltaTime * Math.Sign(direction);
        deg *= Math.Abs(_angle) / 30 + 1;
        _angle += deg;
        transform.Rotate(0, 0, deg);
    }
}
