using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    [SerializeField]
    List<Transform> turnOffOnStart = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform t in turnOffOnStart)
        {
            t.GetComponent<Renderer>().enabled = false;
        }
    }
}
