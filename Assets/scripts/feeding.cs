using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feeding : MonoBehaviour
{
    
    public float speed = 40;
    void Update()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
