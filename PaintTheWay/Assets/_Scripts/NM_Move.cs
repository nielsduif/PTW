using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NM_Move : MonoBehaviour
{
    NavMeshAgent NMA;
    [SerializeField]
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        NMA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        NMA.SetDestination(player.transform.position);
    }
}
