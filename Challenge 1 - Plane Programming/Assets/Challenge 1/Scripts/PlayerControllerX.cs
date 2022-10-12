using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // 1. Asignarle valores predeterminados a las variables
    
    public float speed = 30f;                //velocidad para avanzar
    public float turnSpeed = 60f;           //velocidad para giro
    public float rotationSpeed = 40f;      //velocidad para inclinacion up/down

    public float verticalInput;          //para recibir cuando el usuario presione la tecla up/down

    // 2. Agregarle la variable para que el usuario pueda moverse horizontalmente
    public float horizontalInput;      //para recibir cuando el usuario presione la tecla right/left

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's keys input
        verticalInput = Input.GetAxis("Vertical");

        // 3. Se agrega gracias a L16
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed); //se agrego Time.deltaTime, se cambia a Vector3.forward

        // tilt the plane up/down based on up/down arrow keys
        transform.Translate(Vector3.up * rotationSpeed * Time.deltaTime * verticalInput); //se cambio a Translate ???

        // 4. Se agrega gracias a L16
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * verticalInput); //tilt the plane right/left
        //se agrega verticalInput

    }
}
