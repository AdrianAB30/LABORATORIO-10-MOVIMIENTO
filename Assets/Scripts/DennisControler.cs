using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compspriteRenderer;
    public float speed;
    public float xDirection = 1;
    public float yDirection = 1;
    private void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compspriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {

    }
    void Update()
    {
        _compTransform.position = new Vector2(_compTransform.position.x + speed * xDirection * Time.deltaTime, _compTransform.position.y + speed * yDirection * Time.deltaTime);
        if (_compTransform.position.x >= 6.82)
        {
            xDirection = -1;
            _compspriteRenderer.flipX = true;
        }
        else if (_compTransform.position.x <= -6.82)
        {
            xDirection = 1;
            _compspriteRenderer.flipX = false;
        }
        if (_compTransform.position.y >= 2.9)
        {
            yDirection = -1;
            _compspriteRenderer.flipY = true;
        }
        else if (_compTransform.position.y <= -2.9)
        {
            yDirection = 1;
            _compspriteRenderer.flipY = false;
        }
    }
}