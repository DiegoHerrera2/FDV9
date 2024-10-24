using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamOnEvent : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera cam2;

    
    private void ChangeCamHandler()
    {
        cam2.Priority = 11;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Player")) return;
        ChangeCamHandler();
    }
    
}
