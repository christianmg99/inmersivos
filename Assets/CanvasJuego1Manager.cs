using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasJuego1Manager : MonoBehaviour
{
    [SerializeField] private Controlador controlador;
    
    public void showCanvas(){
        gameObject.SetActive(true);
    }

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