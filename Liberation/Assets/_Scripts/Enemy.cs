using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    //public float Speed;
    //private Rigidbody enemyRB;
    private GameObject player;
    NavMeshAgent enemynvm;
    // Start is called before the first frame update
    void Start()
    {
        //enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Male_01_V01");
        enemynvm = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemyRB.AddForce((player.transform.position - transform.position).normalized * Speed);
        enemynvm.destination = player.transform.position;
    }
}
