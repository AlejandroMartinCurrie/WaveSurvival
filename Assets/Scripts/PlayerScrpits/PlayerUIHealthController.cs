using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUIHealthController : MonoBehaviour
{
    public Image healthOne;
    public Image healthTwo;
    public Image healthThree;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerStatsController.player_Health == 2)
        {
            healthThree.enabled = false;
        }
        if (PlayerStatsController.player_Health == 1)
        {
            healthTwo.enabled = false;
        }
        if (PlayerStatsController.player_Health == 0)
        {
            healthOne.enabled = false;
        }
    }
}
