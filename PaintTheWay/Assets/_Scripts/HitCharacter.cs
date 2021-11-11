using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCharacter : MonoBehaviour
{
    [SerializeField]
    Transform animGO;
    Animator anim;
    [SerializeField]
    string animParam = "Hit";

    private void Start()
    {
        anim = animGO.GetComponent<Animator>();
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.transform.parent == animGO)
        {
            anim.SetBool(animParam, true);
        }
    }
}
