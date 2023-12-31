using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CSTrigger : MonoBehaviour
{
    [SerializeField] private PlayableDirector _director;

    // Start is called before the first frame update
    void Start()
    {
        _director.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _director.Play();
            this.gameObject.SetActive(false);
        }
    }
}
