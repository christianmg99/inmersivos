using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetardoEncender : MonoBehaviour
{
    public float t_ignicion_restante = 7F;
    bool ignicion_iniciada = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ignicion_iniciada == true){
            if (t_ignicion_restante <= 0){
                // El petardo va a explotar, se borra el modelo y se lanzan las particulas
                GameObject.Find("MeshRenderer1").SetActive(false);

                ignicion_iniciada = false;
            }
            else{
                t_ignicion_restante = t_ignicion_restante - Time.deltaTime;
            }
        }
    }

    public void Lanzar()
    {
        // Cuando se interactura con el petardo, se activan las particulas de la mecha y el sonido
        GameObject.Find("Fuse").GetComponent<ParticleSystem>().Play();
        GameObject.Find("Explosion").GetComponent<ParticleSystem>().Play();
        gameObject.GetComponent<AudioSource>().Play();

        ignicion_iniciada = true;
    }

    // Muestra el modelo
    public void showFirecracker(){
        gameObject.SetActive(true);
    }

    public void toggleCanvas(){
        if(gameObject.activeSelf == true){
            gameObject.SetActive(false);
        } else{
            gameObject.SetActive(true);
        }
    }
}
