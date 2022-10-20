using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase Es para Repitir el fondo.
*/

public class RepeatBackground : MonoBehaviour
{
    //variable de tipo Vector3
    private Vector3 startPos;
    //variable para guardar el tamaño de la repetición del fondo
    private float repeatWidth;
  
    void Start()
    {
        //obtenemos la posción del fondo
        startPos = transform.position;
        //Dividimo el fondo en 2
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }



    void Update()
    {
        //Condición para ver cuando repiterse
        if(transform.position.x < startPos.x - repeatWidth)
        {
            //toma la nueva posción
            transform.position = startPos;
        }
    }
}
