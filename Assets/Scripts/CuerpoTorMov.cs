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

        // Calcula la rotación de la cuerpo
        Quaternion cuerpoRotation = Quaternion.Euler(0f, mouseX * cuerpoRotationSpeed, 0f);

        // Aplica la rotación a la cuerpo
        Quaternion newRotation = transform.rotation * cuerpoRotation;

        transform.rotation = newRotation;
    }
}
