using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartParticle : MonoBehaviour
{
    [SerializeField]
    ParticleSystem PS;
    [SerializeField]
    KeyCode startPlaying = KeyCode.Mouse0;
    [SerializeField]
    int ammo = 0, maxAmmo = 3;
    [SerializeField]
    bool hasGun;
    public bool HasGun
    {
        get { return hasGun; }
        set { hasGun = value; }
    }
    public int MaxAmmo
    {
        get { return maxAmmo; }
        set { maxAmmo = value; }
    }
    public int Ammo
    {
        get { return ammo; }
        set { ammo = value; }
    }
    [SerializeField]
    Text ammoTxt;

    // Update is called once per frame
    void Update()
    {
        ammoTxt.text = $"{ammo}/{maxAmmo}";
        if (hasGun && Input.GetKeyDown(startPlaying) && ammo > 0)
        {
            PS.Play();
            ammo--;
        }
    }
}
