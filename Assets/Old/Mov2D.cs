using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov2D : MonoBehaviour
{
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, vertical, 0);

        if (dir.magnitude > 1)
        {
            dir.Normalize();
        }

        Debug.Log(horizontal);
        transform.position += new Vector3(horizontal, vertical) * velocity * Time.deltaTime;    
            
     }
}
