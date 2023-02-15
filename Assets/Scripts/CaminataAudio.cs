using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminataAudio : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip[] caminar4;
    [SerializeField] private AudioClip[] dano2;
    private int aleatorio;

   

    // Update is called once per frame
    void ReproducirCaminata()
    {
        aleatorio = Random.Range(0,3);
        AudioController.Instance.EjecutarSonido(caminar4[aleatorio]);
        
    }
    void ReproducirDano()
    {
        aleatorio = Random.Range(0,1);
        AudioController.Instance.EjecutarSonido(dano2[aleatorio]);
        
    }

}
