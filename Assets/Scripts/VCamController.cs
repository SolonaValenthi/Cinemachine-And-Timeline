using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCamController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _vCams;

    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        SwitchCam();
    }

    private void SwitchCam()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _vCams[0].SetActive(false);
            _vCams[1].SetActive(false);
        }
    }
}
