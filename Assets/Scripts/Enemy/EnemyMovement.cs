using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public PlayerHealth playerHealth;
    public EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    private void Awake ()
    {
        //Cari game
        //object dengan tag player
        player = GameObject.FindGameObjectWithTag("Player").transform;
 
        //Mendapatkan Reference component
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = transform.GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }

    void Update ()
    {
        // //Memindahkan posisi player
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
           nav.SetDestination(player.position);
        }
        //Hentikan moving
        else
        {
            nav.enabled = false;
        }
    }
}
