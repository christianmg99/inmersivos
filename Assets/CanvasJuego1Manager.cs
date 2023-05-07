using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasJuego1Manager : MonoBehaviour
{
    // Capta el objeto controlador
    [SerializeField] private Controlador controlador;
    
    // Muestra el canvas
    public void showCanvas(){
        gameObject.SetActive(true);
    }

    // Esconde el canvas
    public void hideCanvas(){
        gameObject.SetActive(false);
        controlador.activarTemporizador();
    }

    public void toggleCanvas(){
        if(gameObject.activeSelf == true){
            gameObject.SetActive(false);
        } else{
            gameObject.SetActive(true);
        }
    }
}