using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor: José Alejandro Cruz Medina
    Fecha: 26/09/2022
    Descripción:Se usa para destruir las pelotas.
*/

public class DestroyOutOfBoundsX : MonoBehaviour
{
    //Esta variable indica el limite de una pelota que deve alcanzar delado izquierdo.
    private float leftLimit = -40;
    //Esta variable indica el limite de una pelota que deve alcanzar hacía abajo.
    private float bottomLimit = -5;


    void Update()
    {
        // Destruir perros si la posición x es inferior al límite izquierdo
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destruye las bolas si la posición y es menor que bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
