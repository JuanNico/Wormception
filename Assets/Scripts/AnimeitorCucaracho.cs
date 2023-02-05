using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimeitorCucaracho : MonoBehaviour
{

    // variables control animación
    Animator anim;
    public bool noCaminar = true;
    public bool morir = false;

    // variables patrullaje
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntoMovimiento;
    [SerializeField] private float distanciaMinima;
    private int numeroAleatorio;

    //variables para vida

    [SerializeField] private int vida = 1;

   void Start()
    {
        anim = gameObject.transform.GetChild(0).GetComponent<Animator>();
        numeroAleatorio = Random.Range(0,puntoMovimiento.Length);
      Girar();
      
         
    }

    // Update is called once per frame
    void Update()
    {
             //Caminar
         anim.SetBool("Cucaracho walk", true);
        if(noCaminar == true)
        {
            anim.SetBool("Cucaracho walk", false);
           
        }
        
            //morir
        anim.SetBool("She died", false);
        if(morir == true)
        {
           anim.SetBool("She died", true);
         
        }

        // patrullar 

        transform.position = Vector2.MoveTowards(transform.position, puntoMovimiento[numeroAleatorio].position, velocidadMovimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, puntoMovimiento[numeroAleatorio].position) < distanciaMinima)
        {
            numeroAleatorio = Random.Range(0,puntoMovimiento.Length);
            Girar();
        }

    }

    private void Girar()
    {
        if(transform.position.x < puntoMovimiento[numeroAleatorio].position.x)
        {
          gameObject.transform.GetChild(0).localScale = new Vector3 (1f, 1f, 1f);

         //  Debug.Log(gameObject.transform.GetChild(0).name);
        }
        else
        {
         gameObject.transform.GetChild(0).localScale = new Vector3 (-1f, 1f, 1f);

           // Debug.Log(gameObject.transform.GetChild(0).name);
        }
    }
    public void TomarGolpe()
     {
        vida = vida -1;
        if(vida < 0)
        {
            Morir();

        }
     }
    private void Morir()
    {
         anim.SetBool("She died", true);
         velocidadMovimiento = 0;
         gameObject.tag = "0";
         morir = true;
    }
}
