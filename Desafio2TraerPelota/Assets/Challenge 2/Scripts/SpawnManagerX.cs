using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 26/09/2022
    Descripción: Esta es la clase spawnmanager lo que hace es manejar las pelotas.
*/

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
//Variable para indicar el limite de las pelotas al lado izquierdo
    private float spawnLimitXLeft = -22;
    //Variable para indicar el limite de las pelotas al lado derecho.
    private float spawnLimitXRight = 7;
    //Variable para indicar el limite de las pelotas del lado y 
    private float spawnPosY = 30;

    private float startDelay = 1.0f;


 
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Engendra una bola aleatoria en una posición x aleatoria en la parte superior del área de juego.
    void SpawnRandomBall ()
    {
        //se crea la funcion random para lanzar diferentes pelotas.
        int bola = Random.Range(0,3);
        // Generar índice de bola aleatorio y posición de generación aleatoria
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instanciar la bola en una ubicación de generación aleatoria
        Instantiate(ballPrefabs[bola], spawnPos, ballPrefabs[bola].transform.rotation);
    //esta funcion hace que las pelotas salgan entre1 y 5 segundos
        startDelay = Random.Range(1,5);

        Invoke("SpawnRandomBall", startDelay);
    }

}
