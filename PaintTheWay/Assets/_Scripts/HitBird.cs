using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBird : MonoBehaviour
{
    [SerializeField]
    int lives = 10;
    [SerializeField]
    GameObject bird;
    [SerializeField]
    GameObject coin;

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject == bird)
        {
            lives--;
            if (lives <= 0)
            {
                Instantiate(coin, bird.transform.position + new Vector3(0, 1, 0), Quaternion.identity, bird.transform.parent);
                Destroy(bird);
                enabled = false;
            }
        }
    }
}
