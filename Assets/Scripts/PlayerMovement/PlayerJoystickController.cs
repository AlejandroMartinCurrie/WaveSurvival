using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystickController : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    public FixedJoystick lookJoystick;
    public float w_Speed = 10f;



    void UpdateMoveJoystick()
    {
        float hoZ = moveJoystick.Horizontal * w_Speed;
        float veR = moveJoystick.Vertical * w_Speed;

        Vector2 convertedXY = ConvertWithCamera(Camera.main.transform.position, hoZ, veR);
        Vector3 direction = new Vector3(convertedXY.x, 0f, convertedXY.y);
        transform.Translate(new Vector3(direction.x*w_Speed,0f,direction.z * w_Speed) *Time.deltaTime,Space.World);

    }

    void UpdateLookJoystick()
    {
        float hoZ = lookJoystick.Horizontal;
        float veR = lookJoystick.Vertical;

        Vector2 convertedXY = ConvertWithCamera(Camera.main.transform.position, hoZ, veR);
        Vector3 direction = new Vector3(convertedXY.x, 0f, convertedXY.y).normalized;
        Vector3 lookAtPosition = transform.position + direction;
        transform.LookAt(lookAtPosition);

    }


    private Vector2 ConvertWithCamera(Vector3 cameraPos, float hor, float ver)
    {
        Vector2 joyDirection = new Vector2(hor, ver).normalized;
        Vector2 camera2DPos = new Vector2(cameraPos.x, cameraPos.z);
        Vector2 playerPos = new Vector2(transform.position.x, transform.position.z);
        Vector2 cameraToPlyerDirection = (Vector2.zero - camera2DPos).normalized;
        float angle = Vector2.SignedAngle(cameraToPlyerDirection, new Vector2(0, 1));
        Vector2 finalDirection = RotateVector(joyDirection, -angle);
        return finalDirection;
    }

    public Vector2 RotateVector(Vector2 v, float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        float _x = v.x * Mathf.Cos(radian) - v.y * Mathf.Sin(radian);
        float _y = v.x * Mathf.Sin(radian) + v.y * Mathf.Cos(radian);
        return new Vector2(_x, _y);
    }


    void Update()
    {
        UpdateMoveJoystick();
        UpdateLookJoystick();
    }




}
