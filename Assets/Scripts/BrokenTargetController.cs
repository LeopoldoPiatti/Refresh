using UnityEngine;

public class BrokenTargetController : MonoBehaviour
{
    public float despawnTime = 5f;  // Tiempo antes de despawnear las piezas individuales
    public Vector3 spawnRotation;  // Rotaci�n al spawnear

    private void Start()
    {
        // Aplicar la rotaci�n al spawnear
        transform.rotation = Quaternion.Euler(spawnRotation);

        // Destruir las piezas individuales despu�s de despawnTime segundos
        Destroy(gameObject, despawnTime);
    }
}

