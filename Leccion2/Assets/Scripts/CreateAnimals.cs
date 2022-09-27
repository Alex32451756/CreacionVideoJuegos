using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor: José Alejandro Cruz medina 
    Fecha: 25/09/2022
    Descripción: Se crean los animales cada 2 segundos y son aleotoriamente
*/
public class CreateAnimals : MonoBehaviour
{
    //Se crea un arreglo de gameObjet para poder asignarle a los tres animales
    public GameObject[] animales;
  
    void Start()
    {
        //esta funcion lo que hace esque se repite cada 1.5 segundos.
        InvokeRepeating("CrearAnimal", 2, 1.5F);
    }

    void Update()
    {
 


    }
//esta funcion hace que se creen los aniamles aleatoria mente y en diferente posición.
    void CrearAnimal(){
        int aleatorio = Random.Range(0, 3);
        int x = Random.Range(-10, 10);

         Instantiate(animales[aleatorio], new Vector3(x, 0, 15), animales[0].transform.rotation);

    }   
}
