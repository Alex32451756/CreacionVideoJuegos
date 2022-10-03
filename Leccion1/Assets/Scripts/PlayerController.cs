using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 18/09/2022
    Descripción:Esta es la clase Es para nuestro auto esta se encarga de hacerlo avanzar y moverlo.
*/

public class PlayerController : MonoBehaviour
{
    //Se declarar las varibles public para poder haceder a su valor desde la interfaz del juego.
    public float velocidad = 20;
    public float horizotalInput;
    //variable para indicar la velocidad hacia adelante
    public float forwardInput;
    public float turnSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        //Le asignamos que a la variable horizontalInput va a tomar el eje horizontal el cual va hacer que nuestro auto jire.
        horizotalInput = Input.GetAxis("Horizontal");
        //Le asignamos que a la variable forwardInput va a tomar el eje horizontal el cual va hacer que nuestro auto jire.
        forwardInput = Input.GetAxis("Vertical");
        //Con esta funcion hacemos que nuestro auto se mueva hacia delante con una cierta velocidad.
        transform.Translate(Vector3.forward * Time.deltaTime * velocidad * forwardInput);
        //Con esta funcion hacemos que nuestro auto gire con una cierta velocidad.
        transform.Rotate(Vector3.up, turnSpeed * horizotalInput * Time.deltaTime);
    
    }
}
