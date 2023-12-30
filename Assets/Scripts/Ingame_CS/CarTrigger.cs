using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CarTrigger : MonoBehaviour
{
    [SerializeField] PlayableDirector _carDirector;
    [SerializeField] ParticleSystem[] _tireSmoke;

    private bool _canPlay = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && _canPlay == true)
        {
            _carDirector.Play();
            _canPlay = false;
        }
    }

    public void StartEmission()
    {
        foreach (var emitter in _tireSmoke)
        {
            emitter.Play();
        }
    }

    public void StopEmission()
    {
        foreach (var emitter in _tireSmoke)
        {
            emitter.Stop();
        }
    }
}
