using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonFreelook : MonoBehaviour
{
    [Header("Camera")]
    public float sensitivity_horizontal = 100;
    public float sensitivity_vertical = 100;
    public float vertical_max = 80f;
    public float vertical_min = -80f;
    private float yaw = 0;
    private float pitch = 0;
    private float roll = 0;

    [Header("Movement")]
    public float speed_base = 10;

    private void Start()
    {
        Vector3 rotation = transform.localEulerAngles;
        yaw = rotation.y;
        pitch = rotation.x;
        roll = rotation.z;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float forward = Input.GetAxis("Vertical") * speed_base * Time.deltaTime;
        float sideways = Input.GetAxis("Horizontal") * speed_base * Time.deltaTime;
        transform.position += transform.forward * forward;
        transform.position += transform.right * sideways;
    }

    private void LateUpdate()
    {
        float horizontal = Input.GetAxis("Mouse X") * sensitivity_horizontal * Time.deltaTime;
        float vertical = Input.GetAxis("Mouse Y") * sensitivity_vertical * Time.deltaTime;
        yaw += horizontal;
        pitch -= vertical;
        pitch = Mathf.Clamp(pitch, vertical_min, vertical_max);
        transform.localEulerAngles = new Vector3(pitch,  yaw, roll);
    }
}
