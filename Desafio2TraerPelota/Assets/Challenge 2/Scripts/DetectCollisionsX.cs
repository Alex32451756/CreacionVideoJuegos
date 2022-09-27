using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor: José Alejandro Cruz Medina
    Fecha: 26/09/2022
    Descripción:Se usa para poder hacer la colición de las pelotas con el perro.
*/

public class DetectCollisionsX : MonoBehaviour
{
     //se declara la funcion para el colapso de las pelotas.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
