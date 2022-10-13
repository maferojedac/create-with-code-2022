using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float horizontalInput;

    //para que solo se pueda mover 10m en x (derecha-izquierda)
    public float xRange = 18f;

    // Update is called once per frame
    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");

       //da coordenadas en x - transform.position.x
       if(transform.position.x < -xRange)
       {
        //se fija a un rango si supera el limite que se esta dando, se esta definiendo el valor manualmente
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
       }

       if(transform.position.x > xRange)
       {
        //se fija a un rango si supera el limite que se esta dando, se esta definiendo el valor manualmente
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
       }

       transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }
}
