using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupGun : MonoBehaviour
{
    [SerializeField]
    GameObject objectToActivate, player;

    private void Start()
    {
        objectToActivate.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player.gameObject)
        {
            player.GetComponent<StartParticle>().HasGun = true;
            objectToActivate.SetActive(true);
            Destroy(transform.parent.gameObject);
        }
    }
}
