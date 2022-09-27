using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Autor: José Alejandro Cruz Medina
    Fecha: 24/09/2022
    Descripción:Se usa para poder mover la comida de nuestro juego.
*/

public class MovePizza : MonoBehaviour
{
 
    void Start()
    {
        
    }

  
    void Update()
    {
        //Este if es para ferificar que si el obejeto es mayor a 34 en su posición se destruye.
        if(transform.position.z > 34){
            Destroy(gameObject);
        }

    //Tranlate hacemos que la pizza avance hacía adelante
        transform.Translate(Vector3.forward*Time.deltaTime*15);
    }
}
