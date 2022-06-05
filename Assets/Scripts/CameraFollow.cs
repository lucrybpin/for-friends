using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    CinemachineVirtualCamera virtualCamera;

    private void Start()
    {
        GetVirtualCamera();
    }

    private void GetVirtualCamera()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    public void SetTarget(Transform target)
    {
        if (virtualCamera == null)
            GetVirtualCamera();

        virtualCamera.LookAt = target;
        virtualCamera.Follow = target;
    }

    [ContextMenu("SetPlayerTarget")]
    public void SetTargetPlayer()
    {
        SetTarget(FindObjectOfType<Player>().transform.GetChild(0).transform);
    }
}
