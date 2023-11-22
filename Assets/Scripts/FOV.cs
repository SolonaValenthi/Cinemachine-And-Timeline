using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class FOV : MonoBehaviour
{
    [SerializeField] private Transform _cube;
    [SerializeField] private Transform _capsule;
    
    private CinemachineVirtualCamera _vCam;

    // Start is called before the first frame update
    void Start()
    {
        _vCam = GetComponent<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        FOVChange();
        TargetChange();
    }

    private void FOVChange()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_vCam.m_Lens.FieldOfView >= 60)
            {
                _vCam.m_Lens.FieldOfView = 20;
            }
            else
            {
                _vCam.m_Lens.FieldOfView += 20;
            }
        }
    }

    private void TargetChange()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_vCam.LookAt == _cube)
            {
                _vCam.LookAt = _capsule;
            }
            else
            {
                _vCam.LookAt = _cube;
            }
        }
    }
}
