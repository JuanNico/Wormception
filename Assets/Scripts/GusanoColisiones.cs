using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GusanoColisiones : MonoBehaviour
{
    [SerializeField] GameObject hijoGusano;
    [SerializeField] public float dañoGusano;
    [SerializeField] public float GusanoVida;
    [SerializeField] GameObject BarraVida;
    Animator anim;

    void Start()
    {
        dañoGusano = hijoGusano.GetComponent<AnimatorGusano>().DañoRecibir;
        GusanoVida = hijoGusano.GetComponent<AnimatorGusano>().vidaGusano;
         anim = hijoGusano.gameObject.transform.GetChild(0).GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GusanoVida<1f)
            {
                hijoGusano.GetComponent<AnimatorGusano>().MorirGusano();                
                Debug.Log("MorirGusano");
            }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag("1"))
       {
            GusanoVida = GusanoVida + dañoGusano;
            BarraVida.GetComponent<HealthBar>().SetHealth(Mathf.RoundToInt(GusanoVida));
            anim.SetBool("Hit it!", true);
       }
    }
    
  
}
