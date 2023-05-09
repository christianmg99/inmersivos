using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firecracker1 : MonoBehaviour {

    public Rigidbody rig;
    public ConstantForce cf;
    public Transform IsKinematic;

    // Muestra imagen del Firecracker
    public void showFirecracker(){
        gameObject.SetActive(true);
        //Wait for 3 secs.
        //yield return new WaitForSeconds(7);

        //Game object will turn off
        //GameObject.Find("MeshRenderer1").SetActive(false);
        //hideFirecracker();

        //rig.isKinematic = true;
        //cf.enabled = false;
    }

    // Esconde imagen del Firecracker
    public void hideFirecracker(){
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