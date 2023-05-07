using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasJuego2Manager : MonoBehaviour
{
    // Variables para el cambio de imagen
    [SerializeField] public Sprite[] spriteArray1;
    [SerializeField] public Sprite[] spriteArray2;
    [SerializeField] public Sprite[] spriteArray3;

	int current = 0;
	SpriteRenderer spriteRenderer;

    // Captar objeto de imagen
    [SerializeField] public GameObject imagenObj;

    void Start()
	{
        // Captar renderer de la imagen
    	spriteRenderer = imagenObj.GetComponent<SpriteRenderer>();
        ChangeSprite(1);
	}

    public void showCanvas(int mode){
        gameObject.SetActive(true);
        // Cambiar la imagen en funcion de los resultados del juego
        ChangeSprite(mode);
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
 
    // Cambia la imagen
    public void ChangeSprite(int mode)
	{
    	current++;
    	if (current == spriteArray1.Length)
    	{
        	current = 0;
    	}
    	spriteRenderer.sprite = spriteArray1[current];
	}

}