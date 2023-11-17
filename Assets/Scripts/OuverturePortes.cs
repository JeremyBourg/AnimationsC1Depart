using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuverturePortes : MonoBehaviour
{

    [SerializeField] GameObject _porteDroite;
    [SerializeField] GameObject _porteGauche;
    [SerializeField] GameObject _joueur;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre",true);
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre",true);
        }
    }


    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            _porteDroite.GetComponent<Animator>().SetBool("Ouvre",false);
            _porteGauche.GetComponent<Animator>().SetBool("Ouvre",false);
        }
    }
}
