using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [SerializeField]
    GameObject coinRef;

    public void SpawnCoinOnMe()
    {
        Instantiate(coinRef, transform.position + new Vector3(0, 1, 0), Quaternion.identity, transform.parent);
    }
}
