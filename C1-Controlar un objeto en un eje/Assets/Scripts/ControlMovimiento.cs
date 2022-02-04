using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovimiento : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame

    float _speedY = 25f;
    Vector3 _deltaPos = new Vector3();
    const float minLimiteY = -5.0f, maxLimiteY = 5.0f;

    void Update()
    {
        _deltaPos.y = Input.GetAxis("Vertical") * _speedY * Time.deltaTime;
        gameObject.transform.Translate(_deltaPos);
        gameObject.transform.position = new Vector3
            (
                gameObject.transform.position.x,
                Mathf.Clamp(gameObject.transform.position.y, minLimiteY, maxLimiteY),
                gameObject.transform.position.z
            );
    }
}
