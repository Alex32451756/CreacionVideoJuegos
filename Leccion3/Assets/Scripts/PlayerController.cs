using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase Es para las funciones de nustro jugador.
*/

public class PlayerController : MonoBehaviour
{
    //Declaracion de las variables
    //Variable de tipo rigidBody para controlar la masa del jugador
    private Rigidbody playerRb;
    //Variable de tipo Animator para controlar las animaciones
    private Animator playerAnim;
    //Variable de tipo ParticleSystem para guardar el objeto de explosión
    public ParticleSystem explosionParticle;
    //Variable de tipo ParticleSystem para guardar el objeto de explosión
    public ParticleSystem dirtParticle;
    //Variable de tipo AudioClip para guardar el objeto de audio desde la interfaz
    public AudioClip jumpSound;
    //Variable de tipo AudioClip para guardar el objeto de audio desde la interfaz
    public AudioClip crashSound;
    //Variable de tipo AudioClip para guardar el objeto de audio desde la interfaz
    private AudioSource playerAudio;
    //Variable para guardar el valor del salto
    public float jumpForce = 10;
    //Variable para guardar el valor de la gravedad
    public float gravityModifier;
    //Variable para saber si el judador esta en el suelo
    public bool isOnGround = true;
    //Variable para saber si ya termino el juego
    public bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        //Guardamos los componentes de RigidBody en playerRb
        playerRb = GetComponent<Rigidbody>();
        //Inicializamos la gravedad la gravedad
        Physics.gravity *= gravityModifier;
        //Guardamos los componentes de Animator en playerAnim
        playerAnim =  GetComponent<Animator>();
        //Guardamos los componentes de AudioSource en playerAudio
        playerAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Consicion para saber si se esta aplanando la tecla de espacio y se comprueba que el gugador no este en el suelo y el juego no allá terminado
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver){
            //Hacemos que nuestro jugador salte
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            //Cambiamos el valor de la variable a false para indicar que no esta en el suelo
            isOnGround = false;
            //Utilizamos un disparador para utilizar esta función
            playerAnim.SetTrigger("Jump_trig");
            //Detenemos las particulas al saltart
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

//Función para colisionar con los objetos
    private void OnCollisionEnter(Collision collision)
    {
        //Preguntamos que el objeto suelo sea verdadero para ejecutar las animación
        if(collision.gameObject.CompareTag("Ground"))
        {
            //Valor de que no este saltando
            isOnGround = true;
            dirtParticle.Play();
        }else if(collision.gameObject.CompareTag("obstacle"))
        {
            gameOver = true;
            //Imprimimos el mensaje en la consola de game over cuando coliciona con un objeto
            Debug.Log("Game Over!");
            //Encendemos la animacion de muerte
            playerAnim.SetBool("Death_b", true);
            //Escojemos la animacion que queremos que va hacer la numero 1
            playerAnim.SetInteger("DeathType_int", 1);
            //Ejecutanos la animación
            explosionParticle.Play();
            //Detenemos la animación de correr
            dirtParticle.Stop();
            //Ejewcutamos el audio de muerte
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
