using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResiduosRecoger : MonoBehaviour
{
    // Capta el objeto controlador
    [SerializeField] private Controlador controlador;

    public void Tocar(){
        //Game object will turn off
        controlador.objetivoEncontrado();
        Destroy(gameObject);
        // Destroy(GetComponent<Rigidbody>(), 5);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
