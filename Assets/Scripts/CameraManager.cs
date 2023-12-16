using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private CinemachineFreeLook _playerCam;
    [SerializeField] private CinemachineVirtualCamera _staticSecCam; // id 1
    [SerializeField] private CinemachineBlendListCamera _blendSecCam; // id 2
    [SerializeField] private CinemachineVirtualCamera _povSecCam; // id 3

    private bool _secCamsActive = false;
    private int _secCamID = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (_playerCam != null) // default to player camera rig
        {
            _playerCam.Priority = 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_secCamsActive == true)
        {
            SwitchSecCam();
        }
    }

    private void SwitchSecCam()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (_secCamID >= 3)
            {
                _secCamID = 1;
            }
            else
            {
                _secCamID++;
            }

            switch (_secCamID)
            {
                case 1:
                    _staticSecCam.Priority = 100;
                    _blendSecCam.Priority = 10;
                    _povSecCam.Priority = 10;
                    break;
                case 2:
                    _staticSecCam.Priority = 10;
                    _blendSecCam.Priority = 100;
                    _povSecCam.Priority = 10;
                    break;
                case 3:
                    _staticSecCam.Priority = 10;
                    _blendSecCam.Priority = 10;
                    _povSecCam.Priority = 100;
                    break;
                default:
                    Debug.LogError("Ivalid security camera ID was generated. ID reset to 1.");
                    _secCamID = 1;
                    break;
            }
        }
    }

    public void ActivateSecCams()
    {
        _secCamID = 1;
        _secCamsActive = true;
        _playerCam.Priority = 10;
        _staticSecCam.Priority = 100;
    }

    public void ActivatePlayerCam()
    {
        _secCamsActive = false;
        _playerCam.Priority = 100;
        _staticSecCam.Priority = 10;
        _blendSecCam.Priority = 10;
        _povSecCam.Priority = 10;
    }
}
