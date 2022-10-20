using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase para iditar las funciones de las interfaces.
*/


public class GameManager : MonoBehaviour
{
    //Declaramos nuestra lsita
    public List<GameObject> targets;
    //Creando una variable de TMpro
    public TextMeshProUGUI scoreText;

    //Creando una variable de TMpro
    public TextMeshProUGUI gameOverText;

    //Declaramos la variable del bottom
    public Button restartButton;

    public GameObject titleScreen;

    //varible de tiempo de espera
    private float  spawnRate = 1.0f;
    //variable del contador
    private int score;

    //variablke para detener el juego
    public bool isGameActive;

   
    void Start()
    {


    }

    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
           
        }
    }
//función para incrementar el puntaje
    public void updateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    //funcion del fin del juego 
    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        //activamos el mensaje
       gameOverText.gameObject.SetActive(true);
       isGameActive = false;
    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Función para iniciar el juego al precionar algún botón
    public void StartGame( int difficulty)
    {
        //inicialisamos la varibale de inicio de juego
         isGameActive = true;
        //Tomar tiempo en la generación de objetos
        StartCoroutine(SpawnTarget());

        //Inicialisamos la variable del contador
        score = 0;
        
        //Dependiendo la dificulta elejida se divide el tiempo por la dificultad
        spawnRate = spawnRate / difficulty;

        //Lo pintamos en la pantalla con 0
       updateScore(0);

       //Escondemos los botones de inicio de juego
       titleScreen.gameObject.SetActive(false);


    }
}
