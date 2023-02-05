using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScrips : MonoBehaviour
{

    Animator anim;
    public bool remolino = false;
    public bool saltando = false;
    public bool callendo = false;    

    //Variables para golpe
    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float dañoGolpe;

    void Start()
    {
        anim = gameObject.transform.GetChild(0).GetComponent<Animator>();
    }

     void FixedUpdate()
    {
      
      
                    //caminar con normal o con remolino
        anim.SetBool("Walking", false);
        anim.SetBool("Swirl", false);
        if(Input.GetKey("d") || Input.GetKey("right") || Input.GetKey("left") || Input.GetKey("a"))
        {
            
          if(remolino ==true)

          {
            anim.SetBool("Swirl", true);
          }
          else
          {
            anim.SetBool("Walking", true);
          }  
        }

          
            //Saltar
         anim.SetBool("Jump", false);
        if(Input.GetKey("space") || Input.GetKey("up"))
        {
            anim.SetBool("Jump", true);
           
        }
        
            //Ataque
        anim.SetBool("Attack", false);
        if(Input.GetKey("q"))
        {
            anim.SetBool("Attack", true);
              // golpe
           // Golpe();
           
        }

            // Caida

         anim.SetBool("Falling", false);
        if( callendo == true && saltando == false)
        {
            anim.SetBool("Falling", true); 
           
        }
    }
    /*
    private void Golpe()
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);

        foreach (Collider2D colisionador in objetos)
        {
            if(colisionador.CompareTag<Enemigo>().TomarDaño(dañoGolpe));
            {

            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red();
        Gismos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }
    */
}
