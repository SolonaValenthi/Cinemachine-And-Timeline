using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPop : MonoBehaviour
{
    [SerializeField] private GameObject _lightDirector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (_lightDirector.activeInHierarchy == true)
            {
                _lightDirector.SetActive(false);
            }
            else
            {
                _lightDirector.SetActive(true);
            }
        }
    }
}
