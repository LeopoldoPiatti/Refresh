using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLauncher : MonoBehaviour
{
    public GameObject prefab;
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}