using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnStoveOn : MonoBehaviour
{
    [SerializeField] private GameObject _heatMap;

    void Start()
    {
        _heatMap.SetActive(false);
    }
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _heatMap.SetActive(true);
        }
        else
        {
            _heatMap.SetActive(false);
        }
    }
}
