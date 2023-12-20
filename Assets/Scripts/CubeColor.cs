using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    [SerializeField] private MeshRenderer _cubeRenderer;

    private Color _cubeColor;

    // Start is called before the first frame update
    void Start()
    {
        _cubeColor = _cubeRenderer.material.color;
    }

    private void OnEnable()
    {
        _cubeColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        _cubeRenderer.material.color = _cubeColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
