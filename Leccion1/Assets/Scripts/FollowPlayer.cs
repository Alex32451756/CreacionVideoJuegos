using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Autor:José Alejandro Cruz Medina
    Fecha: 18/09/2022
    Descripción: Esta es la clase para que nuestra camara se mueve detras del auto
*/

public class FollowPlayer : MonoBehaviour
{
    //Se declara un objeto de tipo gameObjet para despues aseder con nuestro objeto de auto.
    public GameObject mamalona3;
    //Se le indica la posición
    private Vector3 offset = new Vector3(0, 5, -7);
    
    void Start()
    {
        
    }


    void LateUpdate()
    {
        //Con esto le indicamos que balla avanzando con nuestro auto.
        transform.position = mamalona3.transform.position + offset;
        //////
        ////
    }
}
