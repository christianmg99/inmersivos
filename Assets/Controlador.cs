using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    [SerializeField] private float tiempoMax;
    [SerializeField] private Slider slider;
    private float tiempoAct;
    private bool enCarrera = false;

    /*void Start()
    {
        activarTemporizador();
    }*/

    // Update is called once per frame
    void Update()
    {
        if(enCarrera){
            cambiarContador();
        }
    }

    public void cambiarContador(){
        tiempoAct -= Time.deltaTime;

        if(tiempoAct > 0){
            slider.value = tiempoAct;
        }

        if(tiempoAct <= 0){
            Debug.Log("Se acabó el tiempo");
            desactivarTemporizador();
        }
    }

    public void cambiarTemporizador(bool estado){
        enCarrera = estado;
    }

    public void activarTemporizador(){
        tiempoAct = tiempoMax;
        slider.maxValue = tiempoMax;
        cambiarTemporizador(true);
    }

    public void desactivarTemporizador(){
        cambiarTemporizador(false);
    }

}
