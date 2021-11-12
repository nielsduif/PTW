using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireOut : MonoBehaviour
{
    [SerializeField]
    int lives = 50;
    [SerializeField]
    GameObject fire;
    [SerializeField]
    GameObject[] trees;

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject == fire)
        {
            lives--;
            if (lives < 0)
            {
                Destroy(fire);
                foreach (GameObject t in trees)
                {
                    Destroy(t);
                }
            }
        }
    }
}
