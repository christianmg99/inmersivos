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

    // Captar objeto texto del temporizador
    [SerializeField] private CanvasTemporizadorManager canvasTemporizadorManager;

    // Captar objeto texto del canvas de resultados
    [SerializeField] private CanvasJuego2Manager canvasJuego2Manager;

    // Captar gameobjects de los petardos
    [SerializeField] private Firecracker1 firecracker1;
    [SerializeField] private Rocket1 rocket1;
    [SerializeField] private Rocket2 rocket2;
    [SerializeField] private Rocket3 rocket3;

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
            if(objetivosAct == objetivosMax){
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
        //Mostrar resultados
        canvasJuego2Manager.showCanvas(objetivosAct);
    }

    // Suma uno en el contador de objetos encontrados y actualiza el texto
    public void objetivoEncontrado(){
        // Suma 1
        objetivosAct++;
        // Cambia el texto
        contadorObjetivos.GetComponent<TMPro.TextMeshProUGUI>().text = objetivosAct.ToString() + " de " + objetivosMax.ToString();
    }

    // Funcion que será invocada cuando se quieran mostrar los petardos que lanzará el jugador y oculta la interfaz
    public void mostrarPetardos(){
        // Oculta la interaz
        canvasJuego2Manager.hideCanvas();

        // Si has conseguido 0 objetivos
        if(objetivosAct <= 0){
            // Se muestra un petardo
            firecracker1.showFirecracker();
            Debug.Log("Un petardo");
        } else{
            // Si has conseguido todos los objetivos
            if(objetivosAct >= objetivosMax){
                // Se muestran 3 cohetes
                rocket1.showRocket1();
                rocket2.showRocket2();
                rocket3.showRocket3();
                Debug.Log("Tres cohetes");
            } else{
                // Si se han encontrado algunos objetivos
                // Se muestra 1 cohete
                rocket1.showRocket1();
                Debug.Log("Un cohete");
            }
        }
    }

}
