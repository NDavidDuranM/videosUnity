using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollController : MonoBehaviour
{
    MeshRenderer _renderer;
    const float _scrollingSpeedX = 0.3f;
    Vector2 currentPosition = Vector2.zero;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        currentPosition.x += _scrollingSpeedX * Time.deltaTime;
        _renderer.material.mainTextureOffset = currentPosition;
    }
}
