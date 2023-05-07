using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    // Variables del temporizador
    [SerializeField] private float tiempoMax;
    [SerializeField] private Slider slider;
    private float tiempoAct;
    private bool enPartida;

    // Variables para objetivos de recogida de basura
    private int objetivosAct;
    [SerializeField] private int objetivosMax;

    // Captar objeto texto del contador de objetivos
    [SerializeField] public GameObject contadorObjetivos;

    [SerializeField] private CanvasTemporizadorManager canvasTemporizadorManager;

    void Start(){
        objetivosAct = 0;
        enPartida = false;
        // Set del texto del contador
        contadorObjetivos.GetComponent<TMPro.TextMeshProUGUI>().text = objetivosAct.ToString() + " de " + objetivosMax.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Si se está en partida
        if(enPartida){
            //Si se han recogido los objetivos
            if(objetivosAct == 5){
                // Fin temporizador
                desactivarTemporizador();
                Debug.Log("Has encontrado todos los objetivos");
            } else{
                // Si no, actualiza el temporizador
                cambiarContador();
            }
        }
    }

    // Actualiza el temporizador
    public void cambiarContador(){
        // Se resta el tiempo
        tiempoAct -= Time.deltaTime;

        // Si queda tiempo, se actualiza la imagen
        if(tiempoAct > 0){
            slider.value = tiempoAct;
        } else{
            // Si no, fin partida
            Debug.Log("Se acabó el tiempo");
            desactivarTemporizador();
        }
    }

    // Cambio estado de la partida
    public void cambiarTemporizador(bool estado){
        enPartida = estado;
    }

    // Comienza la partida y muestra el temporizador
    public void activarTemporizador(){
        // Se igualan las variables de tiempo
        tiempoAct = tiempoMax;
        slider.maxValue = tiempoMax;
        // Comienza la partida
        cambiarTemporizador(true);
        // Se muestra el temporizador
        canvasTemporizadorManager.showTemporizador();
    }

    // Finaliza la partida y esconde la imagen del temporizador
    public void desactivarTemporizador(){
        // Finaliza la partida
        cambiarTemporizador(false);
        // Se esconde el temporizador
        canvasTemporizadorManager.hideTemporizador();
    }

    // Suma uno en el contador de objetos encontrados y actualiza el 
    public void objetivoEncontrado(){
        objetivosAct++;
        contadorObjetivos.GetComponent<TMPro.TextMeshProUGUI>().text = objetivosAct.ToString() + " de " + objetivosMax.ToString();
    }

}
