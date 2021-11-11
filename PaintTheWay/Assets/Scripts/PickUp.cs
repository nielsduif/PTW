using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    List<Transform> turnOnObjects = new List<Transform>();

    private void OnTriggerEnter(Collider other)
    {
        foreach (Transform t in turnOnObjects)
        {
            t.gameObject.GetComponent<Renderer>().enabled = true;
        }
        Destroy(gameObject);
    }
}
