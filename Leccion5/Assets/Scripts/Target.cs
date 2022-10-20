using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 20/10/2022
    Descripción:Esta es la clase Es para crar y editar los objetos como su posición.
*/


public class Target : MonoBehaviour
{
    //Creamos la variable de tipo Rigidbody
    private Rigidbody targetRb;
    //variable de GameManager
    private GameManager gameManager;

    //Variable de la instancia de la animación de explosión
    public ParticleSystem explosionParticle;

    //Variables de velocidad
    private float minSpeed = 6;
    private float maxSpeed = 12;
    private float maxTorque = 10;
    //variables de posicion
    private float xRange = 4;
    private float ySpawnPos = -1;

    //Variable para guardar los puntos de cada prefabs
    public int pointValue;


    void Start()
    {
        //Extraemos el componente de rigidbody y se lo asiganmos a la variable targetRB
        targetRb = GetComponent<Rigidbody>();
        //Hacemos la instancia al Scripts de gameManager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        //Cuando tenemos el componente de RigiBody agregamos una fuerza en dirección ascendente
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        //Aplicamos una totación a los objetos
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        //Configuramos las poscion del objeto a salir
        transform.position = RandomSpawnPos();
    }


    void Update()
    {
        
    }

    
    //Destruiur los objetos con el clip del mouse
    private void OnMouseDown()
    {
        //condicion para detenr el juago
        if(gameManager.isGameActive)
        {
            //Se destruyen los objetos
            Destroy(gameObject);

            //Se suman los puntos en el marcador
            gameManager.updateScore(pointValue);

            //Muestra la animación al dar clip
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }

    }

    //Destruir tambien los objetos creados en el juego 
    private void OnTriggerEnter(Collider other) {
         Destroy(gameObject);

         if(!gameObject.CompareTag("Bad"))
         {
            gameManager.GameOver();
         }
    }

//Funcion de posción de los obejtos
     Vector3 RandomForce()
    {
        //retornamos la poscion con la velocidad.
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), -ySpawnPos);
    }   
}

   

