using UnityEngine;

public class BrokenTargetController : MonoBehaviour
{
    public float despawnTime = 5f;  // Tiempo antes de despawnear las piezas individuales
    public Vector3 spawnRotation;  // Rotación al spawnear

    private void Start()
    {
        // Aplicar la rotación al spawnear
        transform.rotation = Quaternion.Euler(spawnRotation);

        // Destruir las piezas individuales después de despawnTime segundos
        Destroy(gameObject, despawnTime);
    }
}

