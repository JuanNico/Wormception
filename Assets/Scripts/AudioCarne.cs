using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCarne : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip comer1;
    /*void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    */
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioController.Instance.EjecutarSonido(comer1);
        }
    }
}
 