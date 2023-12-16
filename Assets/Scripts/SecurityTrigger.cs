using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityTrigger : MonoBehaviour
{
    [SerializeField] private CameraManager _camManager;

    // Start is called before the first frame update
    void Start()
    {
        if (_camManager == null)
        {
            Debug.LogError("Camera Manager reference on " + this.gameObject + " is NULL");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _camManager.ActivateSecCams();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _camManager.ActivatePlayerCam();
        }
    }
}
