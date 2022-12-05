using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public float mouseSpeed;
    float mouseY;
    void Update()
    {
        mouseY += Input.GetAxis("Mouse Y") * mouseSpeed;

        mouseY = Mathf.Clamp(mouseY, -55.0f, 60.0f);
        transform.localEulerAngles = new Vector3(-mouseY, 0, 0);
    }
}
