using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FOV : MonoBehaviour
{
    private CinemachineVirtualCamera _vCam;

    // Start is called before the first frame update
    void Start()
    {
        _vCam = GetComponent<CinemachineVirtualCamera>();
        _vCam.m_Lens.FieldOfView = 40;
        _vCam.Priority = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
