using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameObject brokenTargetPrefab;  // Prefab del target roto
    public float hideTime = 3f;  // Tiempo antes de ocultar el target

    private Renderer targetRenderer;
    private Collider targetCollider;

    private void Start()
    {
        // Obtener el Renderer y el Collider del target
        targetRenderer = GetComponent<Renderer>();
        targetCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            // Ocultar el target
            HideTarget();

            // Ocultar la bala
            Destroy(other.gameObject);

            // Spawnear el target roto en la misma posición
            Instantiate(brokenTargetPrefab, transform.position, Quaternion.identity);
        }
    }

    private void HideTarget()
    {
        // Desactivar el renderizado y los colisionadores
        targetRenderer.enabled = false;
        targetCollider.enabled = false;

        // Establecer un temporizador para mostrar el target nuevamente
        Invoke("ShowTarget", hideTime);
    }

    private void ShowTarget()
    {
        // Activar el renderizado y los colisionadores
        targetRenderer.enabled = true;
        targetCollider.enabled = true;
    }
}


