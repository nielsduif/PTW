using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    MoneyHandler MH;
    [SerializeField]
    StartParticle SP;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            MH.StoreMoney();
            SP.StoreAmmo();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
