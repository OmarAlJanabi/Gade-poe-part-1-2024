using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform body;
    public float sensitivity = 100f;
    float xRotate = 0f;
//Allows camera to be moved with mouse
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        xRotate -= mouseY;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);//Prevents camera from rotating on itself when looking up and down

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        body.Rotate(Vector3.up * mouseX);
    }
}
