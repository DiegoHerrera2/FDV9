using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Zoom : MonoBehaviour
{
    [SerializeField] private float zoomInSize = 5f;
    [SerializeField] private float zoomOutSize = 10f;
    [SerializeField] private float zoomSpeed = 1f;
    private CinemachineVirtualCamera vcam;
    
    private void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }
    
    private void Update()
    {
        // W and S keys are used to zoom in and out
        if (Input.GetKey(KeyCode.W))
        {
            vcam.m_Lens.OrthographicSize = Mathf.Lerp(vcam.m_Lens.OrthographicSize, zoomInSize, Time.deltaTime * zoomSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            vcam.m_Lens.OrthographicSize = Mathf.Lerp(vcam.m_Lens.OrthographicSize, zoomOutSize, Time.deltaTime * zoomSpeed);
        }
    }

}
