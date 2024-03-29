﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectil : MonoBehaviour
{
    public float force = 100;
    public float lifetime = 5.0f; // Tiempo de vida del proyectil en segundos

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * force, ForceMode.VelocityChange);

        // Destruye el objeto después del tiempo especificado por 'lifetime'
        Destroy(gameObject, lifetime); 
    }
}

