using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase Es para Craer los objetos o obstaculos en el juego.
*/


public class SpawnManager : MonoBehaviour
{
    //Variable para guardar las instacias de los objetos
    public GameObject obstaclePrefab;
    //Declaramos la posición de los objetos
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //variable con el valor de tiempo de espera
    private float startDelay = 2;
    //variable para el valor de tiempo para repitirse
    private float repeatRate = 2;
    //Variable de tipo PlayerController
    private PlayerController playerControllerScript;

   
    void Start()
    {
        //IInvocamos la funcion para que se este repitiendo en todo momento
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        //hacemos una instacia del script PlayerController
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Función para crear los obstaculos
    void SpawnObstacle()
    {
        //Preguntamos que el juego no allá terminado
        if(playerControllerScript.gameOver == false)
        {
            //Hacemos la instancia de prefab y creamnos los objetos
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
