using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowCam : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        Time.timeScale = 0.5f;
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        Time.timeScale = 1f;
    }
}
