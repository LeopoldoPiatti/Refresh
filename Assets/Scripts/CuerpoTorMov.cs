using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuerpoTorMov : MonoBehaviour
{
    
    public float cuerpoRotationSpeed = 5f;

    void Update()
    {
        // Obtén el movimiento del ratón del eje X
        float mouseX = Input.GetAxis("Mouse X");

        // Calcula la rotación del cuerpo
        Quaternion cuerpoRotation = Quaternion.Euler(0f, mouseX * cuerpoRotationSpeed, 0f);

        // Aplica la rotación al cuerpo
        Quaternion newRotation = transform.rotation * cuerpoRotation;

        transform.rotation = newRotation;
    }
}
