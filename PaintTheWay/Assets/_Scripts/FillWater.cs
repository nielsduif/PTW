using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillWater : MonoBehaviour
{
    [SerializeField]
    LilyCheck LC;

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject == LC.gameObject)
        {
            LC.MoveUp();
        }
    }
}
