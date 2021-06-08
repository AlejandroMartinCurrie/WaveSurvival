using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public Joystick moveJoystick;
    public Joystick lookJoystick;
    public float w_Speed = 10f;
    public static bool walking;

    
    void UpdateMoveJoystick()
    {
        float hoZ = moveJoystick.Horizontal * w_Speed;
        float veR = moveJoystick.Vertical * w_Speed;
        transform.Translate(new Vector3(hoZ,0f,veR)*Time.deltaTime,Space.World);
        Vector2 movement = new Vector2(moveJoystick.Horizontal,moveJoystick.Vertical);
        if(movement.magnitude> 0.01f)
        {
            walking = true;
        }
        else
        {
            walking = false;
        }
        
    }

    void UpdatePlayerRotation()
    {
        float hoZ = lookJoystick.Horizontal * w_Speed;
        float veR = lookJoystick.Vertical * w_Speed;
        Vector3 playerDirection = new Vector3(hoZ, 0f, veR).normalized;
        Vector3 lookAtPosition = transform.position + playerDirection;
        transform.LookAt(lookAtPosition);
    }


    void Update()
    {
        
        UpdateMoveJoystick();
        UpdatePlayerRotation();
        
    }
}
