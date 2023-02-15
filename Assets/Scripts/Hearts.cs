using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    private int heartHealth = 20;
    Animator anim;
    [SerializeField] private AudioClip comer;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement player = collision.transform.GetComponent<PlayerMovement>();

        if (player != null)
        {
            print("player catch");
            player.Healing(heartHealth);
            anim.SetTrigger("MeatierPick");
            AudioController.Instance.EjecutarSonido(comer);
            Destroy(this.gameObject, 1);
        }
    }
}
