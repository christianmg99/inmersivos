using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket1 : MonoBehaviour
{

    public Rigidbody rig;
    public ConstantForce cf;
    public Transform IsKinematic;

    // Muestra imagen del Rocket1
    public void showRocket1(){
        gameObject.SetActive(true);
        //Wait for 3 secs.
        //yield return new WaitForSeconds(3);

        //Game object will turn off
        //hideRocket1();

        //rig.isKinematic = true;
        //cf.enabled = false;
    }

    // Esconde imagen del Rocket1
    public void hideRocket1(){
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
