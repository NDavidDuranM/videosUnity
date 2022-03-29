using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovimientoInverso : MonoBehaviour
{
    Vector3 _movementSpeed = new Vector3(-25, -25);
    Vector3 _deltaPos = new Vector3();
    const float minLimiteY = -5.0f, maxLimiteY = 5.0f, minLimiteX = -5.0f, maxLimiteX = 5.0f;

    void Update()
    {
        _deltaPos.x = Input.GetAxis("Horizontal") * _movementSpeed.x;
        _deltaPos.y = Input.GetAxis("Vertical") * _movementSpeed.y;
        _deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(_deltaPos);

        gameObject.transform.position = new Vector3
            (
                Mathf.Clamp(gameObject.transform.position.x, minLimiteX, maxLimiteX),
                Mathf.Clamp(gameObject.transform.position.y, minLimiteY, maxLimiteY),
                gameObject.transform.position.z
            );
    }
}
