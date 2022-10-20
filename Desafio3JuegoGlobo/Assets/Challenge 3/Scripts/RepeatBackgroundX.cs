using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase para repitir el fondo.
*/

public class RepeatBackgroundX : MonoBehaviour
{
    //Declaramos una variable de Vector3 para la posición
    private Vector3 startPos;
    //Variable para el ancho del fondo
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        
        //cambismos la variable y por la x ---------
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Set repeat width to half of the background
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


