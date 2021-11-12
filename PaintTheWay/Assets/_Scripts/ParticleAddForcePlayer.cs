using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleAddForcePlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    StartParticle SP;

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject == player)
        {
            SP.BirdWaterHit(SP.Ammo);
        }
    }
}
