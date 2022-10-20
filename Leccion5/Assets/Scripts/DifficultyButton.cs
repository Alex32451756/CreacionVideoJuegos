using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase para crear la dificultad del juego.
*/


public class DifficultyButton : MonoBehaviour
{
    //Varible para llamar la dificultad de los botones
     private Button button;

     //varibale del objeto GameManager
     private GameManager gameManager;

     //Variable para la dificultad
     public int difficulty;

    void Start()
    {
        //Inicialisamos el objeto Button y se lo asignamos a la Varible button
        button = GetComponent<Button>();
        //Usuamos el método onClick para saber que boton se aplana
        button.onClick.AddListener(SetDifficulty);
        //Creamos la instancia y se la asigamos a la variable gameManager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
    }
}
