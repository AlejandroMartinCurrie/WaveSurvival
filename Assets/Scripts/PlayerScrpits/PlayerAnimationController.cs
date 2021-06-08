using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public Animator playerAnimController;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovementController.walking == true)
        {
            playerAnimController.SetBool("Walking", true);
        }
        else
        {
            playerAnimController.SetBool("Walking", false);
        }
    }
}
