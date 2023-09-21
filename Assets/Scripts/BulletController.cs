//using UnityEngine;

//public class BulletController : MonoBehaviour
//{
//    public GameObject targetPrefab;  // Prefab del target roto
//    public float despawnTime = 3f;  // Tiempo antes de desaparecer la bala

//    private void Start()
//    {
//        Destroy(gameObject, despawnTime);  // Destruir la bala después de despawnTime segundos
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("TargetComplete"))
//        {
//            // Destruir el target completo
//            Destroy(other.gameObject);

//            // Destruir la bala
//            Destroy(gameObject);

//            // Spawnear el target roto en la misma posición
//            Instantiate(targetPrefab, other.transform.position, Quaternion.identity);

//            // Establecer un temporizador para respawnear el target completo
//            Invoke("RespawnTargetComplete", 3f);
//        }
//    }

//    private void RespawnTargetComplete()
//    {
//        // Respawnear el target completo en la misma posición
//        Instantiate(targetPrefab, transform.position, Quaternion.identity);
//    }
//}

