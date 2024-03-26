using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;


//Movement Script
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 direction = transform.right * x + transform.forward *z;
        controller.Move(direction * speed * Time.deltaTime);
    }
}
