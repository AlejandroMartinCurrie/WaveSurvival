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
        playerGO =  GameObject.FindGameObjectWithTag("PlayerFollow");
        player = playerGO.transform;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag =="Player")
        {
            PlayerStatsController.player_Health -= 1;
            
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
