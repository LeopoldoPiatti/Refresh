using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonTorMov : MonoBehaviour
{
    public Transform torso;
    public Transform boquilla;
    public float cañonRotationSpeed = 5f;

    private void Start()
    {
        
    }
    void Update()
    {

        // Obtén el movimiento del ratón del eje Y
        float mouseY = Input.GetAxis("Mouse Y");
               
        // Calcula la rotación actual del torso
        Vector3 currentTorsoRotation = torso.localEulerAngles;

        // Calcula la nueva rotación del torso en el eje X (vertical)
        float newTorsoRotationX = (currentTorsoRotation.x - mouseY * cañonRotationSpeed);

        // Aplica la nueva rotación del torso
        torso.localEulerAngles = new Vector3(newTorsoRotationX, currentTorsoRotation.y, currentTorsoRotation.z);

        // La boquilla se moverá con el torso
        boquilla.rotation = torso.rotation;
    }
}
