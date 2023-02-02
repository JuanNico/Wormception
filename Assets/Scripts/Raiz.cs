using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raiz : MonoBehaviour
{
    public GameObject prefactObjeto;
    public GameObject padreObjeto;
    public int anguloMin = 90;
    public int anguloMax = 270;
    public int distanciaY = 3;
    public int rotationHijo1 = 180;

    // Start is called before the first frame update
    void Start()
    {
        //crea el primer hijo
        GameObject hijo1 = Instantiate(prefactObjeto);
        hijo1.transform.parent = padreObjeto.transform; 
        hijo1.transform.localPosition = new Vector3(0,distanciaY,0);
        
        //crea el sgundo hijo lo posiciona y da una rotación aliatoria en Z
        GameObject hijo2 =  Instantiate(prefactObjeto);
        hijo2.transform.parent = hijo1.transform;
        hijo2.transform.localPosition = new Vector3(0,distanciaY,0);
        int randomNumber = Random.Range(anguloMin, anguloMax);
        hijo2.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber);

            GameObject hijo21 =  Instantiate(prefactObjeto);
            hijo21.transform.parent = hijo2.transform;
            hijo21.transform.localPosition = new Vector3(0,distanciaY,0); 
            int randomNumber21 = Random.Range(anguloMin, anguloMax);
            hijo21.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber21);

                GameObject hijo211 =  Instantiate(prefactObjeto);
                hijo211.transform.parent = hijo21.transform;
                hijo211.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber211 = Random.Range(anguloMin, anguloMax);
                hijo211.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber211);

                GameObject hijo212 =  Instantiate(prefactObjeto);
                hijo212.transform.parent = hijo21.transform;
                hijo212.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber212 = Random.Range(anguloMin, anguloMax);
                hijo212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber212);

            GameObject hijo22 =  Instantiate(prefactObjeto);
            hijo22.transform.parent = hijo2.transform;
            hijo22.transform.localPosition = new Vector3(0,distanciaY,0); 
            int randomNumber22 = Random.Range(anguloMin, anguloMax);
            hijo21.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber22);
                
                GameObject hijo221 =  Instantiate(prefactObjeto);
                hijo221.transform.parent = hijo22.transform;
                hijo221.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber221 = Random.Range(anguloMin, anguloMax);
                hijo221.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber221);

                        GameObject hijo2211 =  Instantiate(prefactObjeto);
                    hijo2211.transform.parent = hijo221.transform;
                    hijo2211.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber2211 = Random.Range(anguloMin, anguloMax);
                    hijo2211.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2211);

                    GameObject hijo2212 =  Instantiate(prefactObjeto);
                    hijo2212.transform.parent = hijo221.transform;
                    hijo2212.transform.localPosition = new Vector3(0,distanciaY,0); 
                    int randomNumber2212 = Random.Range(anguloMin, anguloMax);
                    hijo2212.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2212);



                GameObject hijo222 =  Instantiate(prefactObjeto);
                hijo222.transform.parent = hijo22.transform;
                hijo222.transform.localPosition = new Vector3(0,distanciaY,0); 
                int randomNumber222 = Random.Range(anguloMin, anguloMax);
                hijo222.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber222);

        //crea el tercer hijo lo posiciona y da una rotación aliatoria en Z
        GameObject hijo3 =  Instantiate(prefactObjeto);
        hijo3.transform.parent = hijo1.transform;
        hijo3.transform.localPosition = new Vector3(0,distanciaY,0);
        int randomNumber2 = Random.Range(anguloMin, anguloMax);
        hijo3.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber2);
            
            GameObject hijo31 =  Instantiate(prefactObjeto);
            hijo31.transform.parent = hijo3.transform;
            hijo31.transform.localPosition = new Vector3(0,distanciaY,0); 
            int randomNumber31 = Random.Range(anguloMin, anguloMax);
            hijo31.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber31);

            GameObject hijo32 =  Instantiate(prefactObjeto);
            hijo32.transform.parent = hijo3.transform;
            hijo32.transform.localPosition = new Vector3(0,distanciaY,0); 
            int randomNumber32 = Random.Range(anguloMin, anguloMax);
            hijo31.transform.localRotation = Quaternion.Euler(0f, 0f, randomNumber32);

        padreObjeto.transform.rotation = Quaternion.Euler(0f, 0f, rotationHijo1);
    }
}
