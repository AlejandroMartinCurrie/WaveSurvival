using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bullet_Speed;

    private void Start()
    {
        bullet_Speed = 20f;
        transform.parent = null;
    }
    void Update()
    {
        transform.Translate((Vector3.forward * bullet_Speed) * Time.deltaTime);
        
    }
}
