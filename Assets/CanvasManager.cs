using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public void showCanvas(){
        gameObject.SetActive(true);
    }

    public void hideCanvas(){
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
