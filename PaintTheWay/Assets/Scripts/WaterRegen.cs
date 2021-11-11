using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRegen : MonoBehaviour
{
    [SerializeField]
    GameObject player, waterLevel;
    [SerializeField]
    List<ParticleSystem> PS = new List<ParticleSystem>();
    [SerializeField]
    StartParticle SP;
    [SerializeField]
    bool ready;
    Vector3 startPosWater;
    [SerializeField]
    Transform waterEmptyTransform;
    [SerializeField]
    float fillSpeed = .1f;

    // Start is called before the first frame update
    void Start()
    {
        ready = true;
        startPosWater = waterLevel.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ready)
        {
            foreach (ParticleSystem ps in PS)
            {
                if (!ps.isPlaying)
                {
                    ps.Play();
                }
            }
            waterLevel.transform.position = Vector3.MoveTowards(waterLevel.transform.position, startPosWater, fillSpeed * Time.deltaTime);
            if (waterLevel.transform.position.y >= startPosWater.y)
            {
                ready = !ready;
            }
        }
        else if (ready)
        {
            foreach (ParticleSystem ps in PS)
            {
                ps.Stop();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player && SP.HasGun && ready && SP.Ammo < SP.MaxAmmo)
        {
            ready = false;
            waterLevel.transform.position = waterEmptyTransform.position;
            SP.Ammo = SP.MaxAmmo;
        }
    }
}
