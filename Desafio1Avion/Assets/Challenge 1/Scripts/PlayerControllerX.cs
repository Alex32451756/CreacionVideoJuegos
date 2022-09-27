using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Autor:José Alejandro Cruz Medina
    Fecha: 18/09/2022
    Descripción:Esta es la clase Es para nuestro avión esta se encarga de hacerlo avanzar y también de que jire.
*/

public class PlayerControllerX : MonoBehaviour
{
    //Esta variable es para asignarle la velocidad al avíon.
    public float speed;
    //Esta variable es para asignarle la velocidad de rotación al avíon.
    public float rotationSpeed;
    //Esta variable es para asignarle el movimeinto de subida del al avíon.
    public float verticalInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        // obtener la entrada vertical del usuario
        verticalInput = Input.GetAxis("Vertical");

        // mover el avión hacia adelante a una velocidad constante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // inclina el avión hacia arriba/abajo según las teclas de flecha arriba/abajo
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
