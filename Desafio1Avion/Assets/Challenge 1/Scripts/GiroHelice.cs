using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    Autor:José Alejandro Cruz Medina
    Fecha: 18/09/2022
    Descripción: Esta es la clase se utiliza para hacer girar nuestra hélice del avión.
*/

public class GiroHelice : MonoBehaviour
{
    //Creamos la variable velocidadGiro para asignarle un valor indicando que es la velocidad que queremos que se mueva la helice.
    public float velocidadGiro = 1000.0f;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Usamos la funcion ROTATE indicandole que que se vueva para adelante a la velocidad de la variable que creamos arriba y con un cierto tiempo.
        transform.Rotate(Vector3.forward * velocidadGiro * Time.deltaTime);
    }
}
