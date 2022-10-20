using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase Es para mover el fondo y los objetos.
*/

public class MoveLeft : MonoBehaviour
{
    //Variable para la velocidad de los objetos
    private float speed = 30;
    //Cramos una variable de tipo PlayerController
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        //Hacemos una referencia al Script PlayerController
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Co9nsicion para saber que el juego no ha terminado
        if(playerControllerScript.gameOver == false)
        {
            //Movemos el fondo y los objetos al lado izquierrdo 
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        //condicón pora saber si los obejetos traspasaron los limites del juego
        if(transform.position.x < leftBound && gameObject.CompareTag("obstacle"))
        {
            //Destruimos los obstaculos
            Destroy(gameObject);
        }
    }
}
