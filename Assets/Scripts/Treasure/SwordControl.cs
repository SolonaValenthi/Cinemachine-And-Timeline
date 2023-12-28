using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 1f)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 0.5f);
        }

        transform.Rotate(Vector3.up * 0.25f);
    }
}
