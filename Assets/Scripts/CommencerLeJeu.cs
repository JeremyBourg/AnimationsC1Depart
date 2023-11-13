using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommencerLeJeu : MonoBehaviour
{
    public void CommencerLaPartie(){
        SceneManager.LoadScene("Scene1");
    }
}
