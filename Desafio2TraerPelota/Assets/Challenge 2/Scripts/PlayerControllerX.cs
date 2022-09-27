using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 26/09/2022
    Descripción: Esta es la clase para nuestro jugador.
*/

public class PlayerControllerX : MonoBehaviour
{
    //dogPreab es uan variable del objeto gameObjet para elegir a nuestro perro
    public GameObject dogPrefab;
    //Declaramos la variable tiempoespera y le asignamos 1 segundo.
    private float tiempoEspera = 1;
    //esta variable sera para la incrementacion del tiempo en el juego. 
    private float tiempoSiguienteDisparo = 0;


    void Update()
    {
        // Presiona la barra espaciadora, envía perro
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiempoSiguienteDisparo)
        {
            tiempoSiguienteDisparo = Time.time + tiempoEspera;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
