using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform torso;
    public Transform boquilla;
    public float baseRotationSpeed = 5f;
    public float torsoRotationSpeed = 5f;
    public float maxBaseRotationAngle = 90f;  // Máximo ángulo de rotación de la base en grados
    public float minBaseRotationAngle = -90f;  // Mínimo ángulo de rotación de la base en grados
    public float maxTorsoAngle = 60f;  // Máximo ángulo de rotación del torso en grados
    public float minTorsoAngle = -30f;  // Mínimo ángulo de rotación del torso en grados

    void Update()
    {
        // Obtén el movimiento del ratón en los ejes X e Y
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calcula la rotación de la base
        Quaternion baseRotation = Quaternion.Euler(0f, mouseX * baseRotationSpeed, 0f);

        // Aplica la rotación a la base
        Quaternion newRotation = transform.rotation * baseRotation;

        // Limita la rotación de la base dentro del rango definido
        Vector3 newEulerAngles = newRotation.eulerAngles;
        newEulerAngles.y = Mathf.Clamp(newEulerAngles.y, minBaseRotationAngle, maxBaseRotationAngle);
        newRotation = Quaternion.Euler(newEulerAngles);

        transform.rotation = newRotation;

        // Calcula la rotación actual del torso
        Vector3 currentTorsoRotation = torso.localEulerAngles;

        // Calcula la nueva rotación del torso en el eje X (vertical)
        float newTorsoRotationX = Mathf.Clamp(
            currentTorsoRotation.x - mouseY * torsoRotationSpeed,
            minTorsoAngle,
            maxTorsoAngle
        );

        // Aplica la nueva rotación del torso
        torso.localEulerAngles = new Vector3(newTorsoRotationX, currentTorsoRotation.y, currentTorsoRotation.z);

        // La boquilla se moverá con el torso
        boquilla.rotation = torso.rotation;
    }
}





