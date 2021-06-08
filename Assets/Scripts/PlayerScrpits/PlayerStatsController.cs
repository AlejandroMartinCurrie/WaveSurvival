using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsController : MonoBehaviour
{
    public static int player_Health;




    public void PlayerDeathController()
    {
        if(player_Health <= 0)
        {
            Destroy(gameObject);
        }
    }



    void Start()
    {
        player_Health = 3;
    }




    // Update is called once per frame
    void Update()
    {
        PlayerDeathController();
    }
}
