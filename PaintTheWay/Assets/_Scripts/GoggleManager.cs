using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoggleManager : MonoBehaviour
{
    [SerializeField]
    Image goggleOverlay;
    [SerializeField]
    List<GameObject> goggleObjects = new List<GameObject>();
    [SerializeField]
    float timer, maxTime = 10;
    bool active;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateGoggles();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < maxTime && active)
        {
            timer += Time.deltaTime;
        }
        else if (active)
        {
            DeactivateGoggles();
        }
    }

    public void ActicateGoggles()
    {
        active = true;
        goggleOverlay.gameObject.SetActive(true);
        foreach (GameObject g in goggleObjects)
        {
            g.SetActive(true);
        }
        timer = 0;
    }

    void DeactivateGoggles()
    {
        active = false;
        goggleOverlay.gameObject.SetActive(false);
        foreach (GameObject g in goggleObjects)
        {
            g.SetActive(false);
        }
    }
}
