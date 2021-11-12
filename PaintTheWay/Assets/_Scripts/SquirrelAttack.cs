using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelAttack : MonoBehaviour
{
    [SerializeField]
    GameObject player, bullet;
    [SerializeField]
    Transform shootPoint;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }
}
