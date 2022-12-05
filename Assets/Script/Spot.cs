using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour
{
    public float mouseSpeed;
    float mouseY;
    public float mousespeed = 3.0f;
    float currentRot;
    public Camera fpsCam;


    void Update()
    {
        mouseY += Input.GetAxis("Mouse Y") * mouseSpeed;

        mouseY = Mathf.Clamp(mouseY, -55.0f, 60.0f);
        transform.localEulerAngles = new Vector3(-mouseY, 0, 0);
        float rotX = Input.GetAxis("Mouse Y") * mousespeed;
        float rotY = Input.GetAxis("Mouse X") * mousespeed;

        currentRot -= rotX;

        currentRot = Mathf.Clamp(currentRot, -80f, 80f);

        this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);


    }
}
