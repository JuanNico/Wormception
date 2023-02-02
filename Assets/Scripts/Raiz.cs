using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raiz : MonoBehaviour
{
    public GameObject prefactObjeto;
    public GameObject padreObjeto;
    public int anguloMin = -90;
    public int anguloMax = 90;
    public float distanciaY = 3;
    public int rotationHijo1 = 180;
    public int bifurcacion = 1;
    public Vector3 escalaAnimacion = new Vector3(1f,1f,1f);
    public float velocidadAnimacion = 1;
    // Start is called before the first frame update

    
    void Start()
    {
        Raiz2();
    }
    

     void Raiz1()
     {

     

         //crea el primer hijo
        GameObject hijo1 = Instantiate(prefactObjeto);
        hijo1.transform.parent = padreObjeto.transform; 
        hijo1.transform.localPosition = new Vector3(0,distanciaY,0);

        LeanTween.scale(hijo1, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();

        hijo1.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 11;


        if(bifurcacion>= 1)
        {
                //crea el sgundo hijo lo posiciona y da una rotación aliatoria en Z
            GameObject hijo2 =  Instantiate(prefactObjeto);
            hijo2.transform.parent = hijo1.transform;
            hijo2.transform.localPosition = new Vector3(0,distanciaY,0);
                // se ajustan los angulos para que la raiz centran apunte mas al fondo
            int randomNumber = Random.Range(-60, 60);
            hijo2.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber);
            hijo2.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
             IEnumerator Wait()
                {
                    yield return new WaitForSeconds(velocidadAnimacion);
                   LeanTween.scale(hijo2, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                }
             StartCoroutine(Wait());

                 //crea el tercer hijo lo posiciona y da una rotación aliatoria en Z
            GameObject hijo3 =  Instantiate(prefactObjeto);
            hijo3.transform.parent = hijo1.transform;
            hijo3.transform.localPosition = new Vector3(0,distanciaY,0);
            int randomNumber2 = Random.Range(anguloMin, anguloMax);
            hijo3.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2);
             hijo3.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
            IEnumerator Wait1()
                {
                    yield return new WaitForSeconds(velocidadAnimacion);
                   LeanTween.scale(hijo3, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                }
             StartCoroutine(Wait1());
            if(bifurcacion>= 2)
            {
                GameObject hijo21 =  Instantiate(prefactObjeto);
                hijo21.transform.parent = hijo2.transform;
                hijo21.transform.localPosition = new Vector3(0,distanciaY,0); 
                    // se ajustan los angulos para que la raiz centran apunte mas al fondo
                int randomNumber21 = Random.Range(-60, 60);
                hijo21.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber21);

                 hijo21.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                 IEnumerator Wait3()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo21, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait3());

                GameObject hijo22 =  Instantiate(prefactObjeto);
                hijo22.transform.parent = hijo2.transform;
                hijo22.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber22 = Random.Range(anguloMin, anguloMax);
                hijo21.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22);
                hijo22.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                IEnumerator Wait4()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo22, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait4());

                GameObject hijo31 =  Instantiate(prefactObjeto);
                hijo31.transform.parent = hijo3.transform;
                hijo31.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber31 = Random.Range(anguloMin, anguloMax);
                hijo31.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber31);
                 hijo31.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                IEnumerator Wait5()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo31, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait5());

                GameObject hijo32 =  Instantiate(prefactObjeto);
                hijo32.transform.parent = hijo3.transform;
                hijo32.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber32 = Random.Range(anguloMin, anguloMax);
                hijo31.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber32);

                 hijo32.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                IEnumerator Wait6()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo32, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait6());

                if(bifurcacion>=3)
                {
                    GameObject hijo211 =  Instantiate(prefactObjeto);
                    hijo211.transform.parent = hijo21.transform;
                    hijo211.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber211 = Random.Range(anguloMin, anguloMax);
                    hijo211.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber211);

                     hijo211.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait7()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion * 3);
                           LeanTween.scale(hijo211, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait7());

                    GameObject hijo212 =  Instantiate(prefactObjeto);
                    hijo212.transform.parent = hijo21.transform;
                    hijo212.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber212 = Random.Range(anguloMin, anguloMax);
                    hijo212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber212);

                    hijo212.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait8()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion *3);
                           LeanTween.scale(hijo212, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait8());

                    GameObject hijo221 =  Instantiate(prefactObjeto);
                    hijo221.transform.parent = hijo22.transform;
                    hijo221.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber221 = Random.Range(anguloMin, anguloMax);
                    hijo221.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber221);

                    hijo221.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait9()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion *3);
                           LeanTween.scale(hijo221, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait9());


                    GameObject hijo222 =  Instantiate(prefactObjeto);
                    hijo222.transform.parent = hijo22.transform;
                    hijo222.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber222 = Random.Range(anguloMin, anguloMax);
                    hijo222.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber222);

                    hijo222.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait10()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion *3);
                           LeanTween.scale(hijo222, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait10());

                    //faltan los hijos de 32 y 31

                    if(bifurcacion>=4)
                    {
                        //hijos de 211

                        GameObject hijo2211 =  Instantiate(prefactObjeto);
                        hijo2211.transform.parent = hijo221.transform;
                        hijo2211.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2211 = Random.Range(anguloMin, anguloMax);
                        hijo2211.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2211);

                        hijo2211.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait11()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2211, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait11());

                        GameObject hijo2212 =  Instantiate(prefactObjeto);
                        hijo2212.transform.parent = hijo221.transform;
                        hijo2212.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2212 = Random.Range(anguloMin, anguloMax);
                        hijo2212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2212);

                        hijo2212.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait12()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2212, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait12());

                        GameObject hijo2221 =  Instantiate(prefactObjeto);
                        hijo2221.transform.parent = hijo222.transform;
                        hijo2221.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2221 = Random.Range(anguloMin, anguloMax);
                        hijo2221.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2221);

                        hijo2221.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait13()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2221, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait13());

                        GameObject hijo2222 =  Instantiate(prefactObjeto);
                        hijo2222.transform.parent = hijo222.transform;
                        hijo2222.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2222 = Random.Range(anguloMin, anguloMax);
                        hijo2222.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2222);

                        hijo2222.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait14()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2222, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait14());

                        if(bifurcacion>=5)
                        {

                            GameObject hijo22111 =  Instantiate(prefactObjeto);
                        hijo22111.transform.parent = hijo2212.transform;
                        hijo22111.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22111 = Random.Range(anguloMin, anguloMax);
                        hijo22111.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22111);

                        hijo22111.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait15()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22111, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait15());

                        GameObject hijo22122 =  Instantiate(prefactObjeto);
                        hijo22122.transform.parent = hijo2212.transform;
                        hijo22122.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22122 = Random.Range(anguloMin, anguloMax);
                        hijo22122.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22122);

                        hijo22122.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait16()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22122, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait16());

                        GameObject hijo22212 =  Instantiate(prefactObjeto);
                        hijo22212.transform.parent = hijo2222.transform;
                        hijo22212.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22212 = Random.Range(anguloMin, anguloMax);
                        hijo22212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22212);

                        hijo22212.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait17()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22212, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait17());

                        GameObject hijo22222 =  Instantiate(prefactObjeto);
                        hijo22222.transform.parent = hijo2222.transform;
                        hijo22222.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22222 = Random.Range(anguloMin, anguloMax);
                        hijo22222.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22222);

                        hijo22222.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait18()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22222, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait18());

                        }



                    }
                }
            }
        }
        
    padreObjeto.transform.rotation = Quaternion.Euler(0f, 0f, rotationHijo1);
            
    }

 
     void Raiz2()
     {

    

        if(bifurcacion>= 1)
        {
                //crea el sgundo hijo lo posiciona y da una rotación aliatoria en Z
            GameObject hijo2 =  Instantiate(prefactObjeto);
            hijo2.transform.parent = padreObjeto.transform;
            hijo2.transform.localPosition = new Vector3(0,distanciaY,0);
                // se ajustan los angulos para que la raiz centran apunte mas al fondo
            int randomNumber = Random.Range(-60, 60);
            hijo2.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber);
            hijo2.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
             IEnumerator Wait()
                {
                    yield return new WaitForSeconds(velocidadAnimacion);
                   LeanTween.scale(hijo2, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                }
             StartCoroutine(Wait());

                 //crea el tercer hijo lo posiciona y da una rotación aliatoria en Z
            GameObject hijo3 =  Instantiate(prefactObjeto);
            hijo3.transform.parent = padreObjeto.transform;
            hijo3.transform.localPosition = new Vector3(0,distanciaY,0);
            int randomNumber2 = Random.Range(anguloMin, anguloMax);
            hijo3.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2);
             hijo3.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
            IEnumerator Wait1()
                {
                    yield return new WaitForSeconds(velocidadAnimacion);
                   LeanTween.scale(hijo3, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                }
             StartCoroutine(Wait1());
            if(bifurcacion>= 2)
            {
                GameObject hijo21 =  Instantiate(prefactObjeto);
                hijo21.transform.parent = hijo2.transform;
                hijo21.transform.localPosition = new Vector3(0,distanciaY,0); 
                    // se ajustan los angulos para que la raiz centran apunte mas al fondo
                int randomNumber21 = Random.Range(-60, 60);
                hijo21.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber21);

                 hijo21.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                 IEnumerator Wait3()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo21, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait3());

                GameObject hijo22 =  Instantiate(prefactObjeto);
                hijo22.transform.parent = hijo2.transform;
                hijo22.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber22 = Random.Range(anguloMin, anguloMax);
                hijo21.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22);
                hijo22.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                IEnumerator Wait4()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo22, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait4());

                GameObject hijo31 =  Instantiate(prefactObjeto);
                hijo31.transform.parent = hijo3.transform;
                hijo31.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber31 = Random.Range(anguloMin, anguloMax);
                hijo31.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber31);
                 hijo31.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                IEnumerator Wait5()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo31, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait5());

                GameObject hijo32 =  Instantiate(prefactObjeto);
                hijo32.transform.parent = hijo3.transform;
                hijo32.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber32 = Random.Range(anguloMin, anguloMax);
                hijo31.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber32);

                 hijo32.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 9;
                IEnumerator Wait6()
                    {
                        yield return new WaitForSeconds(velocidadAnimacion + velocidadAnimacion);
                       LeanTween.scale(hijo32, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                    }
                 StartCoroutine(Wait6());

                if(bifurcacion>=3)
                {
                    GameObject hijo211 =  Instantiate(prefactObjeto);
                    hijo211.transform.parent = hijo21.transform;
                    hijo211.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber211 = Random.Range(anguloMin, anguloMax);
                    hijo211.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber211);

                     hijo211.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait7()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion * 3);
                           LeanTween.scale(hijo211, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait7());

                    GameObject hijo212 =  Instantiate(prefactObjeto);
                    hijo212.transform.parent = hijo21.transform;
                    hijo212.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber212 = Random.Range(anguloMin, anguloMax);
                    hijo212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber212);

                    hijo212.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait8()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion *3);
                           LeanTween.scale(hijo212, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait8());

                    GameObject hijo221 =  Instantiate(prefactObjeto);
                    hijo221.transform.parent = hijo22.transform;
                    hijo221.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber221 = Random.Range(anguloMin, anguloMax);
                    hijo221.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber221);

                    hijo221.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait9()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion *3);
                           LeanTween.scale(hijo221, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait9());


                    GameObject hijo222 =  Instantiate(prefactObjeto);
                    hijo222.transform.parent = hijo22.transform;
                    hijo222.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber222 = Random.Range(anguloMin, anguloMax);
                    hijo222.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber222);

                    hijo222.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 8;

                    IEnumerator Wait10()
                        {
                            yield return new WaitForSeconds(velocidadAnimacion *3);
                           LeanTween.scale(hijo222, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                        }
                     StartCoroutine(Wait10());

                    //faltan los hijos de 32 y 31

                    if(bifurcacion>=4)
                    {
                        //hijos de 211

                        GameObject hijo2211 =  Instantiate(prefactObjeto);
                        hijo2211.transform.parent = hijo221.transform;
                        hijo2211.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2211 = Random.Range(anguloMin, anguloMax);
                        hijo2211.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2211);

                        hijo2211.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait11()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2211, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait11());

                        GameObject hijo2212 =  Instantiate(prefactObjeto);
                        hijo2212.transform.parent = hijo221.transform;
                        hijo2212.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2212 = Random.Range(anguloMin, anguloMax);
                        hijo2212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2212);

                        hijo2212.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait12()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2212, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait12());

                        GameObject hijo2221 =  Instantiate(prefactObjeto);
                        hijo2221.transform.parent = hijo222.transform;
                        hijo2221.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2221 = Random.Range(anguloMin, anguloMax);
                        hijo2221.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2221);

                        hijo2221.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait13()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2221, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait13());

                        GameObject hijo2222 =  Instantiate(prefactObjeto);
                        hijo2222.transform.parent = hijo222.transform;
                        hijo2222.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber2222 = Random.Range(anguloMin, anguloMax);
                        hijo2222.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2222);

                        hijo2222.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 7;

                        IEnumerator Wait14()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*4);
                               LeanTween.scale(hijo2222, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait14());

                        if(bifurcacion>=5)
                        {

                            GameObject hijo22111 =  Instantiate(prefactObjeto);
                        hijo22111.transform.parent = hijo2212.transform;
                        hijo22111.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22111 = Random.Range(anguloMin, anguloMax);
                        hijo22111.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22111);

                        hijo22111.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait15()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22111, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait15());

                        GameObject hijo22122 =  Instantiate(prefactObjeto);
                        hijo22122.transform.parent = hijo2212.transform;
                        hijo22122.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22122 = Random.Range(anguloMin, anguloMax);
                        hijo22122.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22122);

                        hijo22122.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait16()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22122, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait16());

                        GameObject hijo22212 =  Instantiate(prefactObjeto);
                        hijo22212.transform.parent = hijo2222.transform;
                        hijo22212.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22212 = Random.Range(anguloMin, anguloMax);
                        hijo22212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22212);

                        hijo22212.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait17()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22212, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait17());

                        GameObject hijo22222 =  Instantiate(prefactObjeto);
                        hijo22222.transform.parent = hijo2222.transform;
                        hijo22222.transform.localPosition = new Vector3(0,distanciaY,0); 
                        int randomNumber22222 = Random.Range(anguloMin, anguloMax);
                        hijo22222.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22222);

                        hijo22222.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;

                        IEnumerator Wait18()
                            {
                                yield return new WaitForSeconds(velocidadAnimacion*5);
                               LeanTween.scale(hijo22222, escalaAnimacion, velocidadAnimacion).setEaseOutQuad();
                            }
                         StartCoroutine(Wait18());

                        }



                    }
                }
            }
        }
        
    padreObjeto.transform.rotation = Quaternion.Euler(0f, 0f, rotationHijo1);
            
    }

       
    
}
