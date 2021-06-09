using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bullet_Speed;
    public float bullet_Life;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        
        bullet_Speed = 20f;
        transform.parent = null;
    }
    void Update()
    {
        bullet_Life += Time.deltaTime;
        transform.Translate((Vector3.forward * bullet_Speed) * Time.deltaTime);
        if(bullet_Life >= 4)
        {
            Destroy(gameObject);
        }
        
    }
}
