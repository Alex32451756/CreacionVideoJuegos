using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//josé Alejandro cruz medina
/*
    Autor: José Alejandro Cruz Medina
    Fecha: 24/09/2022
    Descripción:Se usa para poder mover el player y ensi mismo crear una pizza de donde este el player
*/
public class MoveHuman : MonoBehaviour
{
    //Esta variable espara indicar la velocidad de movimiento de nuestro jugador. 
    public float vel = 100.0F;
    //esta variable es para indicarle el maximo del rango donde se desplaze el jugador.
    public float maximo = 22;
    //Se declara una variable del tipo gameObjet para nuestro objeto de comida
    public GameObject Pizza;

    void Start()
    {
        
    }

  
    void Update()
    {
        //En este if se pregunta que cuando se aplane la tecla M se cree un objeto de comida.
        if(Input.GetKeyDown(KeyCode.M)){
            //Aquí lo que hacemos es que nuestra comida salga de la posición de donde este nuestro jugador.
            Instantiate(Pizza, transform.position, Pizza.transform.rotation);
        }
        //Comprobamos que la posición x sea mayor que el maximo si es asì el jugador no podra avanzar.
        if(transform.position.x > maximo){
            transform.position = new Vector3(maximo, transform.position.y, transform.position.z);
        }
        //Comprobamos que la posición x sea menor que el maximo si es asì el jugador no podra avanzar.
        if(transform.position.x < -maximo){
            transform.position = new Vector3(-maximo, transform.position.y, transform.position.z);
        }
        float flechas = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*vel*flechas);
    }
}
