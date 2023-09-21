using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int scoreValueLess;
    public CameraShake cameraShake;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            //Resta 100 puntos y mueve la camara
            UiManager.scoreValue -= scoreValueLess;
            cameraShake.ShakeCamera();
        }
    }
}
