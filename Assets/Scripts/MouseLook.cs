using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform torso;
    public Transform boquilla;
    public float baseRotationSpeed = 5f;
    public float torsoRotationSpeed = 5f;
    public float maxBaseRotationAngle = 90f;  // M�ximo �ngulo de rotaci�n de la base en grados
    public float minBaseRotationAngle = -90f;  // M�nimo �ngulo de rotaci�n de la base en grados
    public float maxTorsoAngle = 60f;  // M�ximo �ngulo de rotaci�n del torso en grados
    public float minTorsoAngle = -30f;  // M�nimo �ngulo de rotaci�n del torso en grados

    void Update()
    {
        // Obt�n el movimiento del rat�n en los ejes X e Y
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calcula la rotaci�n de la base
        Quaternion baseRotation = Quaternion.Euler(0f, mouseX * baseRotationSpeed, 0f);

        // Aplica la rotaci�n a la base
        Quaternion newRotation = transform.rotation * baseRotation;

        // Limita la rotaci�n de la base dentro del rango definido
        Vector3 newEulerAngles = newRotation.eulerAngles;
        newEulerAngles.y = Mathf.Clamp(newEulerAngles.y, minBaseRotationAngle, maxBaseRotationAngle);
        newRotation = Quaternion.Euler(newEulerAngles);

        transform.rotation = newRotation;

        // Calcula la rotaci�n actual del torso
        Vector3 currentTorsoRotation = torso.localEulerAngles;

        // Calcula la nueva rotaci�n del torso en el eje X (vertical)
        float newTorsoRotationX = Mathf.Clamp(
            currentTorsoRotation.x - mouseY * torsoRotationSpeed,
            minTorsoAngle,
            maxTorsoAngle
        );

        // Aplica la nueva rotaci�n del torso
        torso.localEulerAngles = new Vector3(newTorsoRotationX, currentTorsoRotation.y, currentTorsoRotation.z);

        // La boquilla se mover� con el torso
        boquilla.rotation = torso.rotation;
    }
}





