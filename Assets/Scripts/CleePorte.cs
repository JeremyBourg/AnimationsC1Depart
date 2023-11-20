using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleePorte : MonoBehaviour
{

    [SerializeField] GameObject _porte;
    [SerializeField] GameObject _clee;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player"){
            _porte.GetComponent<Animator>().SetBool("Start",true);
            _clee.SetActive(false);
        }
    }
}
