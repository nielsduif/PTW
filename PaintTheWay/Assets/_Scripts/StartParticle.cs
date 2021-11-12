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
        set
        {
            maxAmmo = value;
            ammoTxt.text = $"{ammo}/{maxAmmo}";
        }
    }
    public int Ammo
    {
        get { return ammo; }
        set { ammo = value; }
    }
    [SerializeField]
    Text ammoTxt;

    [SerializeField]
    Button G;
    [SerializeField]
    GoggleManager GM;
    [SerializeField]
    bool firstRun;

    private void Start()
    {
        if (firstRun)
        {
            PlayerPrefs.SetInt("Ammo", Ammo);
            PlayerPrefs.SetInt("MaxAmmo", MaxAmmo);
        }
        else
        {
            Ammo = PlayerPrefs.GetInt("Ammo");
            MaxAmmo = PlayerPrefs.GetInt("MaxAmmo");
        }
    }

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

    public void StealWater(int _amount)
    {
        int temp = ammo;
        if ((temp -= _amount) < 0)
        {
            return;
        }
        ammo -= _amount;
        if (GM != null)
        {
            GM.ActicateGoggles();
        }
    }

    public void BirdWaterHit(int _amount)
    {
        int temp = ammo;
        if ((temp -= _amount) < 0)
        {
            return;
        }
        ammo -= _amount;
    }

    public void StoreAmmo()
    {
        PlayerPrefs.SetInt("Ammo", Ammo);
        PlayerPrefs.SetInt("MaxAmmo", MaxAmmo);
    }
}
