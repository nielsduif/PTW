using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSegments : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject segmentToActivate;
    MeshRenderer[] mr;
    [SerializeField]
    List<Transform> additionalObjects = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        mr = segmentToActivate.GetComponentsInChildren<MeshRenderer>();
        ToggleMR(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            ToggleMR(true);
            Destroy(gameObject);
        }
    }

    void ToggleMR(bool state)
    {
        foreach (MeshRenderer _rm in mr)
        {
            _rm.enabled = state;
        }

        foreach (Transform t in additionalObjects)
        {
            t.gameObject.SetActive(state);
        }
    }
}
