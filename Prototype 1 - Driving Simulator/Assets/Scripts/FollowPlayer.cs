using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //GameObject-tipo de dato que encapsula cualquier objeto que puede estar en la escena
    public GameObject player; 
    private Vector3 offset = new Vector3(0,5,-10);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate es llamado despues de Update para que la cámara no se vea vibrando 
    //ya que el carro va mas rapido que la camara
    void LateUpdate()
    {
        //toma el transform del player para que siga al player
        //new-porque estamos declarando el vector
        transform.position = player.transform.position + offset;
    }
}
