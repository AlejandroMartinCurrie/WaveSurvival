using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    public Transform player;
    public GameObject playerGO;
    public float moveSpeed;
    public float minDistance;
    public float maxDistance;

    void Start()
    {
        playerGO =  GameObject.FindGameObjectWithTag("Player");
        player = playerGO.transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("Hello");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            PlayerStatsController.player_Health -= 1;
            //print(PlayerStatsController.player_Health);
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(player);
        if(Vector3.Distance(transform.position, player.position) >= minDistance)
         {

            transform.position += transform.forward * moveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, player.position) <= maxDistance)
            {
                //Aquyi hacer que haga la animacion de atacar si a llegado al personaje
            }

        }

    }
}
