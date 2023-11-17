using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorcheMain : MonoBehaviour
{

    [SerializeField] GameObject _torcheMur;
    [SerializeField] GameObject _torcheMain;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            _torcheMain.SetActive(true);
            _torcheMur.SetActive(false);
        }
    }
}
