using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RaceCameras : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _raceCam;
    [SerializeField] private CinemachineVirtualCamera _finishLineCam;
    [SerializeField] private CinemachineVirtualCamera _endingCam;

    // Start is called before the first frame update
    void Start()
    {
        _raceCam.Priority = 100;
        _finishLineCam.Priority = 10;
        _endingCam.Priority = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToFinish()
    {
        _raceCam.Priority = 10;
        _finishLineCam.Priority = 100;
        _endingCam.Priority = 10;
        Time.timeScale = 0.25f;
    }

    public void SwitchToEnd()
    {
        Time.timeScale = 1.0f;
    }
}
