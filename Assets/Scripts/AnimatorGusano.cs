using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorGusano : MonoBehaviour
{
 Animator anim;
    public bool remolino = false;
    public bool saltando = false;
    public bool callendo = false;    
    public int vidaGusano = 10;

   

    void Start()
    {
        anim = gameObject.transform.GetChild(0).GetComponent<Animator>();
    }

     void FixedUpdate()
    {
      
      
                    //caminar con normal o con remolino
        anim.SetBool("Walking", false);
        anim.SetBool("Swirl", false);
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
           gameObject.transform.localScale = new Vector3 (1f, 1f, 1f);  
          if(remolino ==true)

          {
            anim.SetBool("Swirl", true);
          }
          else
          {
            anim.SetBool("Walking", true);
          }  
        }

        if(Input.GetKey("left") || Input.GetKey("a"))
        {
        
        gameObject.transform.localScale = new Vector3 (-1f, 1f, 1f);
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

           
        }

            // Caida

         anim.SetBool("Falling", false);
        if( callendo == true && saltando == false)
        {
            anim.SetBool("Falling", true); 
           
        }
    }
    
    
    
}
