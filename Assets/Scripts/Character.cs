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

    private Vector3 _direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TankMovement();
        CameraSwitch();
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
}