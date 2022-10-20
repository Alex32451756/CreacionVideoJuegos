using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase Es para las funciones de nustro jugador.
*/

public class PlayerControllerX : MonoBehaviour
{
    //Variable para saber el estatus del juego
    public bool gameOver;
    //Variable para la fueza
    public float floatForce;
    //variable para la gravedad
    private float gravityModifier = 1.5f;
    //variable de tipo Rigibody
    private Rigidbody playerRb;
    //variable para las animaciones
    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;
    //variables para los audios
    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;


    // Start is called before the first frame update
    void Start()
    {
    //Asiganamos la gravedad
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        //inicialisamos la varibale-------
        playerRb = GetComponent<Rigidbody>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
        //aplicamos la fuerza al vector3
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            //le damos play a la animación
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

    }

}
