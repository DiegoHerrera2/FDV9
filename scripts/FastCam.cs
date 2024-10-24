using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastCam : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        Time.timeScale = 2f;
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        Time.timeScale = 1f;
    }
}
