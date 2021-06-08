using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject bulletToShoot;
    public Transform shootingLocation;
    public float fr;

    void Start()
    {
       
    }

    IEnumerator ShootingTimeController()
    {
        yield return new WaitForSeconds(3f);
        CreateBullet();
       
    }

    public void CreateBullet()
    {
        Instantiate(bulletToShoot, shootingLocation);
    }

    

    // Update is called once per frame
    void Update()
    {
        fr += Time.deltaTime;

        if(fr > 3)
        {
            CreateBullet();
            fr = 0;
        }
        
    }
}
