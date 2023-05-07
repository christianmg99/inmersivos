using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResiduosGiraYFlota : MonoBehaviour
{
    public float velocidadGiro = 0.1F;
    public float velocidadFlote = 0.0002F;
    public float limiteSuperiorInferior = 0.1F;
    bool bajando = true;
    float alturaInicial;

    // Start is called before the first frame update
    void Start()
    {
        alturaInicial = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        // Cuando haya llegado abajo del todo, cambia a subir
        if (transform.position.y <= alturaInicial - limiteSuperiorInferior){
            bajando = false;
        }
        // Cuando haya llegado arriba del todo, cambia a bajar
        if (transform.position.y >= alturaInicial + limiteSuperiorInferior){
            bajando = true;
        }
        // Movimiento de subir/bajar
        Vector3 direccion;
        if (bajando == true){
            direccion = new Vector3(transform.position.x, alturaInicial - limiteSuperiorInferior, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, direccion, velocidadFlote);
        }
        else{
            direccion = new Vector3(transform.position.x, alturaInicial + limiteSuperiorInferior, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, direccion, velocidadFlote);
        }
        // Movimiento de giro
        Vector3 giro = new Vector3(0, velocidadGiro, 0);
        transform.Rotate(giro);
    }
}
