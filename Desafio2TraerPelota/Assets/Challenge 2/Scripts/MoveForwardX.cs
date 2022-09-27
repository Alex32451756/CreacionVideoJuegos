using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 26/09/2022
    Descripción: Esta es la clase para que nuestro perro se mueva.
*/

public class MoveForwardX : MonoBehaviour
{
    //Se declara la varible de velocidad de movimiento 
    public float speed;


    void Update()
    {
        //Usamos la función translate para moverlo hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
