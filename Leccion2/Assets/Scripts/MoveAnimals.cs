using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 24/09/2022
    Descripción:Esta es la clase Es para hacer que los animales se muevan.
*/

public class MoveAnimals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //En este if lo que comparamos esque si la posición de los animales en menor a -14.1 se destruyan.
        if(transform.position.z < -14.1){
            Destroy(gameObject);
        }

        //Con esto hacemos que nuestro animales caminen hacía delante con un velocidad de 10
        transform.Translate(Vector3.forward * Time.deltaTime * 10);
    }
}
