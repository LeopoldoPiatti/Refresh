using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLauncher : MonoBehaviour
{
    public GameObject prefab;
    public float positionOffset = 2;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(prefab, transform.position + transform.forward * positionOffset, transform.rotation);
        }
    }
}