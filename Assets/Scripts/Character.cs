using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private CinemachineVirtualCamera _3rdPerson;
    [SerializeField] private CinemachineVirtualCamera _orbital;
    [SerializeField] private CinemachineVirtualCamera[] _triggerCams;

    private bool _isADS = false;
    private Vector3 _direction;

    Animator _charAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _charAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        TankMovement();
        //CameraSwitch();
        ADS();
    }

    private void TankMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        _direction = new Vector3(0, 0, vertical);
        _direction *= _moveSpeed * Time.deltaTime;
        _direction = this.transform.TransformDirection(_direction);
        _controller.Move(_direction);


        Vector3 rotation = new Vector3(0, horizontal * _rotateSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);
    }

    private void CameraSwitch()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _orbital.Priority = 100;
        }

        if (Input.GetMouseButtonUp(1))
        {
            _orbital.Priority = 10;
        }
    }

    private void ADS()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            _isADS = true;
        }
        else
        {
            _isADS = false;
        }

        _charAnimator.SetBool("isAiming", _isADS);
    }

    private void TriggerSwitch(int vcamID)
    {
        foreach (var camera in _triggerCams)
        {
            camera.Priority = 10;
        }

        _triggerCams[vcamID].Priority = 100;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube 1")
        {
            TriggerSwitch(0);
        }
        if (other.tag == "Cube 2")
        {
            TriggerSwitch(1);
        }
        if (other.tag == "Cube 3")
        {
            TriggerSwitch(2);
        }
        if (other.tag == "Cube 4")
        {
            TriggerSwitch(3);
        }
    }
}
