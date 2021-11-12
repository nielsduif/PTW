using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolorBucket : MonoBehaviour
{
    [SerializeField]
    GameObject bucket;
    [SerializeField]
    Material m;
    [SerializeField]
    int lives = 20;
    Collider c;

    private void Start()
    {
        c = bucket.GetComponent<Collider>();
        c.enabled = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject == bucket)
        {
            lives--;
            if (lives < 10)
            {
                bucket.GetComponentInChildren<Renderer>().material = m;
                c.enabled = true;
            }
        }
    }
}
