using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasTemporizadorManager : MonoBehaviour
{
    // Muestra imagen del temporizador
    public void showTemporizador(){
        gameObject.SetActive(true);
    }

    // Esconde imagen del temporizador
    public void hideTemporizador(){
        gameObject.SetActive(false);
    }

    public void toggleCanvas(){
        if(gameObject.activeSelf == true){
            gameObject.SetActive(false);
        } else{
            gameObject.SetActive(true);
        }
    }
}
