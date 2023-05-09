using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteLanzar : MonoBehaviour
{
    public float t_vuelo_restante = 3F;
    public float t_ignicion_restante = 3F;
    bool lanzamiento_iniciado = false;
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
                // El cohete esta listo para salir volando, activa el movimiento continuo hacia arriba y el sonido
                gameObject.GetComponent<ConstantForce>().enabled = true;
                gameObject.GetComponent<AudioSource>().Play();

                ignicion_iniciada = false;
                lanzamiento_iniciado = true;
            }
            else{
                t_ignicion_restante = t_ignicion_restante - Time.deltaTime;
            }
        }

        if (lanzamiento_iniciado == true){
            if (t_vuelo_restante <= 0){
                // Al pasar el tiempo de lanzamiento, el modelo desaparece
                GameObject.Find("MeshRenderer").SetActive(false);
                gameObject.GetComponent<ConstantForce>().enabled = false;  // cf.enabled = false;

                // Y se activa la animacion de las particulas
                GameObject.Find("ParticleSystem1").GetComponent<ParticleSystem>().Play();
                GameObject.Find("ParticleSystem2").GetComponent<ParticleSystem>().Play();

                gameObject.GetComponent<Rigidbody>().isKinematic = true;  // rig.isKinematic = true;
                
                lanzamiento_iniciado = false;
            }
            else{
                t_vuelo_restante = t_vuelo_restante - Time.deltaTime;
            }
        }
    }

    public void Lanzar()
    {
        // Cuando se interactura con el cohete, se activan las particulas de la propulsion del cohete
        GameObject.Find("RocketPropulsion").GetComponent<ParticleSystem>().Play();

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
