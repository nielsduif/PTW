using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    Animator anim;
    [SerializeField]
    string animParam = "Open";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            anim.SetBool(animParam, true);
            Destroy(gameObject);
        }
    }
}
