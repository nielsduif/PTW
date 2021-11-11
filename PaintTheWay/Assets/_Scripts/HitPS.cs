using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPS : MonoBehaviour
{
    [SerializeField]
    GameObject PS, objectToActivate;
    Collider c;

    private void Start()
    {
        c = objectToActivate.GetComponent<Collider>();
        c.enabled = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject == PS)
        {
            c.enabled = true;
            PS.SetActive(false);
        }
    }
}
