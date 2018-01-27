using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotator : MonoBehaviour {

    public float wheelSpeed;

    void Update()
    {
        WheelRotateSpeed();
    }

    void WheelRotateSpeed()
    {
        transform.Rotate(0.0f, 0.0f, wheelSpeed * Time.deltaTime);
    }

}
