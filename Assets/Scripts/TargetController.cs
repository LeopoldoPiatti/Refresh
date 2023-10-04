using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameObject brokenTargetPrefab;  // Prefab del target roto
    public float hideTime = 3f;  // Tiempo antes de ocultar el target

    public int scoreValue;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            // Ocultar el target
            HideTarget();
                       
            //Agregar 100 puntos
            UiManager.scoreTotal += scoreValue;

            // Spawnear el target roto en la misma posición
            Instantiate(brokenTargetPrefab, transform.position, Quaternion.identity);
        }
    }

    private void HideTarget()
    {
        
        this.gameObject.SetActive(false);

        // Establecer un temporizador para mostrar el target nuevamente
        Invoke("ShowTarget", hideTime);
    }

    private void ShowTarget()
    {
        this.gameObject.SetActive(true);
    }
}


