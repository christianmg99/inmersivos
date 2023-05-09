using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasJuego2Manager : MonoBehaviour
{
	Image image;

    // Captar objeto de imagen
    [SerializeField] public GameObject imagenObj;

    // Captar objeto del texto de los resultados
    [SerializeField] public GameObject textoObjetivosEncontrados;

    // Muestra el canvas y ajusta el texto e imagen a mostrar en él.
    public void showCanvas(int objetivosEncontrados){
        gameObject.SetActive(true);
        // Definir texto de resultados
        textoObjetivosEncontrados.GetComponent<TMPro.TextMeshProUGUI>().text = "Has recogido " + objetivosEncontrados + " de los 6 objetivos";
        // Captar renderer de la imagen
    	image = imagenObj.GetComponent<Image>();
        // Cambiar la imagen en funcion de los resultados del juego
        ChangeSprite(objetivosEncontrados);
    }

    // Esconde el canvas
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
 
    // Cambia la imagen
    public void ChangeSprite(int objetivosEncontrados)
	{
        // Si no se ha encontrado ningún objetivo
    	if(objetivosEncontrados <= 0){
            // Imagen petardo
            image.sprite = Resources.Load<Sprite>("Sprites/Cracker");
            Debug.Log("Has encontrado 0 objetivos, aquí tienes un petardo");
        } else{
            // Si se han encontrado todos
            if(objetivosEncontrados >= 6){
                // Imagen cohete x1
                image.sprite = Resources.Load<Sprite>("Sprites/cohetex3");
                Debug.Log("Has encontrado los 5 objetivos, aquí tienes 3 cohetes");
            } else{
                // Si se han recogido alguno pero no todos
                // Imagen cohete x3
                image.sprite = Resources.Load<Sprite>("Sprites/cohetex1");
                Debug.Log("Has encontrado algunos objetivos, aquí tienes un cohete");
            }
        }
	}

}