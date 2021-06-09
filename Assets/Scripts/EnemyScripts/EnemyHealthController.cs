using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthController : MonoBehaviour
{
    public int enemy_health;




    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            enemy_health -= 1;
        }
    }


    void Start()
    {
        enemy_health = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
