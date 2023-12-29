using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ChestControl : MonoBehaviour
{
    [SerializeField] private GameObject _openPrompt;
    [SerializeField] private PlayableDirector _director;
    [SerializeField] private GameObject _swordPrefab;
    [SerializeField] private ParticleSystem _chestPop;

    private bool _canOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        _openPrompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _canOpen == true)
        {
            _canOpen = false;
            _openPrompt.SetActive(false);
            OpenChest();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _openPrompt.SetActive(true);
            _canOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _openPrompt.SetActive(false);
            _canOpen = false;
        }
    }

    private void OpenChest()
    {
        _director.Play();
    }

    public void SpawnSword()
    {
        Instantiate(_swordPrefab, transform.position, Quaternion.identity);
        _chestPop.Play();
    }
}
