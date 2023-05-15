using UnityEngine;
using Cinemachine;

public class uiCamManager : MonoBehaviour
{
   
public CinemachineVirtualCamera currentCamera;



    void Start()
    {
        currentCamera.Priority++;
    }

    
public void UpdateCamera(CinemachineVirtualCamera target)
{
    currentCamera.Priority--;

    currentCamera = target;

    currentCamera.Priority++;
}
}