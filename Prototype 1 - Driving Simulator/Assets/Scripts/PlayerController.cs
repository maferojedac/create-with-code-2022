using System.Collections; //estandar de C#
using System.Collections.Generic; //estandar de C#
using UnityEngine;

public class PlayerController : MonoBehaviour //todo lo de Unity hereda de MonoBehaviour
{
    //variable para velocidad
    //float-el más recomendable en unity porque usan 5 veces menos memoria que double
    //20f-para que Unity sepa que le estás pasando un float
    //public-poder editar la velocidad fuera de la clase
    public float speed = 20f;

    //para velocidad de giro
    public float turnSpeed = 60f;

    //se ponen las variables en public para que el diseñador pueda hacer pruebas
    //tendria que conservarse en public si queremos mover los valores desde otros scripts

    //para saber a donde se quiere mover el personaje - horizontalmente
    public float horizontalInput;

    //para saber a donde se quiere mover el personaje - verticalmente
    public float forwardInput;


    // Update is called once per frame
    void Update()
    {
        //obtiene la tecla que el usuario apreto (solo da 2 valores: 1=derecha, -1=izquierda)
        horizontalInput = Input.GetAxis("Horizontal");

        //obtiene la tecla que el usuario apreto (solo da 2 valores: 1=adelante, -1=atras)
        forwardInput = Input.GetAxis("Vertical");

        //operador punto-localizacion dentro de otra localizacion
        //transform-componente del objeto al cual esta el 
        //Translate-metodo
        //script de movimiento infinito
        // transform.Translate(0, 0, 1); lo mismo que en L44

        //Vector-son más convenientes y legibles
        //Time-para pausar el juego, cuánto tiempo ha pasado desde el último cuadro
        //se mueve hacia adelante 1m*s, con el 20 se mueve 20m*s
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 

        //para movernos a la derecha
        /* transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);  */

        //cambiando L44 para que el carro rote
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); 
    }
}
