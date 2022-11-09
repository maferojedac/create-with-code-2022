using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // LateUpdate is called once per frame, after Update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}