using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket3 : MonoBehaviour
{

    public Rigidbody rig;
    public ConstantForce cf;
    public Transform IsKinematic;

    // Muestra imagen del rocket 3
    public void showRocket3(){
        gameObject.SetActive(true);
        //Wait for 3 secs.
        //yield return new WaitForSeconds(2);

        //Game object will turn off
        //hideRocket3();

        //rig.isKinematic = true;
        //cf.enabled = false;
    }

    // Esconde imagen del rocket 3
    public void hideRocket3(){
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
