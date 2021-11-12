using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTrigger : MonoBehaviour
{
    [SerializeField]
    NM_Move nm_move;
    [SerializeField]
    GameObject player;
    StartParticle SP;
    [SerializeField]

    // Start is called before the first frame update
    void Start()
    {
        SP = player.GetComponent<StartParticle>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            SP.BirdWaterHit(SP.Ammo);
        }
    }
}
