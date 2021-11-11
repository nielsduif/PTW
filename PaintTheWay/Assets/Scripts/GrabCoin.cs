using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCoin : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    MoneyHandler MH;

    private void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        if (MH == null)
        {
            MH = GameObject.FindObjectOfType<MoneyHandler>();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            MH.AddMoney();
            Destroy(gameObject);
        }
    }
}
