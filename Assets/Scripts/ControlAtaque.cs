using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAtaque : MonoBehaviour
{
     //Variables para golpe
    [SerializeField] private Transform controladorGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float dañoGolpe;
    [SerializeField] GameObject wormie;
    public bool controlGusano = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controlGusano = wormie.GetComponent<AnimatorGusano>().control;
        if(controlGusano==false)
        {

             if(Input.GetKey("q"))
            
            {
                Golpe();  

            }
        }
    }
    public void Golpe()
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controladorGolpe.position, radioGolpe);

        foreach (Collider2D colisionador in objetos)
        {
            if(colisionador.CompareTag("1"))
            {
                Debug.Log("colision");

                colisionador.transform.GetComponent<AnimeitorCucaracho>().TomarGolpe();
              
            }
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controladorGolpe.position, radioGolpe);
    }
}
