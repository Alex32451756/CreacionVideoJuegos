using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variable de velocidad
    private float speed = 10.0f;
    //variable para limitar la posición
    private float zBound = 6;
    //Usamos rigidbody para controlar los movimientos
    private Rigidbody playerRb;


 
    void Start()
    {
        // extraemos el componente para poder usarlo
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        MovePlayer();
        ConstrainPlayerPosition();

    }

    //mover al jugador con las flechas
    void MovePlayer()
    {
        //Declaramos los variables de movimiento 
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        //Se declara los movimeinetos que van atner cada flecha 
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    //Paredes que limmitan al jugador salir de la area de juego
    void ConstrainPlayerPosition()
    {
        //condicion para limitar la posicion de nuestro player
        if(transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
    //Condición para ver que no trespase nuestra barrera de juego
        if(transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        
    }
}
