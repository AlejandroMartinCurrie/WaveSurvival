using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryController : MonoBehaviour
{
    public Button retryButton;
    


    public void RetryGame()
    {
        SceneManager.LoadScene("Game_Scene");
    }

    void Start()
    {
        retryButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerStatsController.player_Health == 0) 
        {
            retryButton.gameObject.SetActive(true);
        }
    }
}
