using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float top = 30f;
    public float bot = -20f;
    void Update()
    {
        if (transform.position.z > top)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bot)
        {
            Destroy(gameObject);
            Debug.Log("Gameover!");
        }
    }
}
