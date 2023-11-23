using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VCamSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera[] _bodyCams;

    private int _currentIndex = 0;
    private int _arrayLength;
    
    // Start is called before the first frame update
    void Start()
    {
        _bodyCams[0].Priority = 100;
        _arrayLength = _bodyCams.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchCamera();
        }
    }

    private void SwitchCamera()
    {
        int nextIndex;

        if (_currentIndex >= _arrayLength)
        {
            nextIndex = 0;
        }
        else
        {
            nextIndex = _currentIndex + 1;
        }

        _bodyCams[_currentIndex].Priority = 10;
        _bodyCams[nextIndex].Priority = 100;

        _currentIndex = nextIndex;
    }
}
