using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCamera : MonoBehaviour
{
    private List<CinemachineVirtualCamera> cameras;
    private int currentCameraIndex = 0;
    
    private void Start()
    {
        cameras = new List<CinemachineVirtualCamera>();
        foreach (Transform child in transform)
        {
            CinemachineVirtualCamera camera = child.GetComponent<CinemachineVirtualCamera>();
            if (camera != null)
            {
                cameras.Add(camera);
            }
        }
    }
    
    // Use J and K to switch between cameras
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            cameras[currentCameraIndex].gameObject.SetActive(false);
            currentCameraIndex = (currentCameraIndex - 1 + cameras.Count) % cameras.Count;
            cameras[currentCameraIndex].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            cameras[currentCameraIndex].gameObject.SetActive(false);
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Count;
            cameras[currentCameraIndex].gameObject.SetActive(true);
        }
    }
    
    
}
