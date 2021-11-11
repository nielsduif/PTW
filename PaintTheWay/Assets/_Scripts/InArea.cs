using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InArea : MonoBehaviour
{
    [SerializeField]
    ShopHandler SH;
    [SerializeField]
    GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            SH.InArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            SH.InArea = false;
        }
    }
}
