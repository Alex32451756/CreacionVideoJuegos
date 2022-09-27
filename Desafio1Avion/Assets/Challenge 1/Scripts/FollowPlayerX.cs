using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 18/09/2022
    Descripción: Esta es la clase para que nuestra camara se mueve detras del avíon.
*/

 
public class FollowPlayerX : MonoBehaviour
{
    //Se declara publico el objeto para poder asignarlo al aviòn
    public GameObject plane;
    //Se crea la variable offset y se la asigna la posciciòn de la camara.
    private Vector3 offset = new Vector3(20, 2, 0);

 
    void Start()
    {

    }


    void Update()
    {
        //Creamos la funcion para que nuestra camara siga nuestro avìòn.
        transform.position = plane.transform.position + offset;
    }
}
