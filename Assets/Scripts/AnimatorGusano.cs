using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimatorGusano : MonoBehaviour
{
 Animator anim;
    public bool remolino = false;
    public bool saltando = false;
    public bool callendo = false;    
    public float vidaGusano = 10;
    public bool control = false;
    public float DañoRecibir = -0.5f;
    public Vector3 escalaInicial; 
    public GameObject padreGusano;
    private float moveX;
    private bool mirandoDerecha;
    public Vector3 posicion1;
    public Vector3 posicion2;
    public float velocidadMuerte = 0.5f;
    [SerializeField] private AudioClip[] audioSalto;
   // [SerializeField] private AudioClip audioAtaque;
    public int Salto7;
    private int caminar4;
    [SerializeField] private AudioClip[] audioCaminar;
    public bool der;

   

    void Start()
    {
        anim = gameObject.transform.GetChild(0).GetComponent<Animator>();
        escalaInicial= gameObject.transform.localScale;
    }

     void FixedUpdate()
    {
      
        if(control==false)
        {
            
                        //caminar con normal o con remolino
            anim.SetBool("Walking", false);
            anim.SetBool("Swirl", false);

            if(remolino)
            {
               anim.SetBool("Swirl", true); 
            }

            if(Input.GetKey("d") || Input.GetKey("right"))
            {
                moveX = 1;
               gameObject.transform.localScale = new Vector3 (escalaInicial.x * 1f,escalaInicial.y , escalaInicial.z);  
              
                anim.SetBool("Walking", true);
                caminar4 = Random.Range(0,3);
                
            }

            if(Input.GetKey("left") || Input.GetKey("a"))
            {
            
            gameObject.transform.localScale = new Vector3 (escalaInicial.x * -1f,escalaInicial.y , escalaInicial.z);
            
                anim.SetBool("Walking", true);
                caminar4 = Random.Range(0,3);
            }

            if(remolino ==true)
              {
                anim.SetBool("Swirl", true);
              }

                //nuevo codigo de correcion
            posicion1 = gameObject.transform.position;
            IEnumerator WaitT()
                {
                    yield return new WaitForSeconds(1f);
                }
            StartCoroutine(WaitT());
            posicion2 = gameObject.transform.position;
            moveX = posicion2.x - posicion1.x;


            if(moveX<1)
            {
                if(mirandoDerecha)
                {
                    gameObject.transform.localScale = new Vector3 (escalaInicial.x * 1f,escalaInicial.y , escalaInicial.z);
                }
                else
                {
                    gameObject.transform.localScale = new Vector3 (escalaInicial.x * -1f,escalaInicial.y , escalaInicial.z);
                }
            }

            if(moveX==0)
            {
                if(mirandoDerecha)
                {
                    gameObject.transform.localScale = new Vector3 (escalaInicial.x * 1f,escalaInicial.y , escalaInicial.z);
                }
                else
                {
                    gameObject.transform.localScale = new Vector3 (escalaInicial.x * -1f,escalaInicial.y , escalaInicial.z);
                }
            }

                //Saltar
             anim.SetBool("Jump", false);
            if(Input.GetKeyDown("space"))
            {
                anim.SetBool("Jump", true);
                
                Salto7 = Random.Range(0,7);
                AudioController.Instance.EjecutarSonido(audioSalto[Salto7]);
                Debug.Log(Salto7);
                StartCoroutine(WaitS());
              
            }
            
           

                // Caida

             
            if( callendo == true)
            {
                anim.SetBool("Falling", true);    
            }

                // Daños

             anim.SetBool("Hit it!", false);
             anim.SetBool("Memory", false);

            if(vidaGusano<1f)
            {
                MorirGusano();

            }
        }    

        // para la barra de vida

    }

   

    private IEnumerator WaitS()
    {
        Debug.Log("Empezando a esperar");
        saltando = true;
        yield return new WaitForSeconds(0.7f);
        Debug.Log("Finalizando la espera");
          saltando = false;
    }

    //Falta decidir si se usa OnCollisionStay2D o OnCollisionEnter2D
    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag("1"))
       {
        vidaGusano = vidaGusano + DañoRecibir;
         anim.SetBool("Hit it!", true);
       }
    }
    */
    public void MorirGusano()
    {
        
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + -0.0001f, gameObject.transform.position.y, gameObject.transform.position.z);
        padreGusano.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        anim.SetBool("Memory", true);
        gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
        Debug.Log("murio");
        control = true;
        Vector3 force = new Vector3(velocidadMuerte, 0, 0);

        StartCoroutine(WaitToDie());
        
    }
    IEnumerator WaitToDie()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
  
}
