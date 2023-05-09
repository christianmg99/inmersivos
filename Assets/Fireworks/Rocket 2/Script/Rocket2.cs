using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket2 : MonoBehaviour
{

    public Rigidbody rig;
    public ConstantForce cf;
    public Transform IsKinematic;

    // Muestra imagen del Rocket2
    public void showRocket2(){
        gameObject.SetActive(true);
        //Wait for 3 secs.
        //yield return new WaitForSeconds(3);

        //Game object will turn off
        //hideRocket2();

        //rig.isKinematic = true;
        //cf.enabled = false;
    }

    // Esconde imagen del Rocket2
    public void hideRocket2(){
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
