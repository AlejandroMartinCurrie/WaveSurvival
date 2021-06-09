using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelectorController : MonoBehaviour
{

    public int mapNumber;

    void Start()
    {
       
    }

    public void MapSelected1()
    {
        mapNumber = 1;
        PlayerPrefs.SetInt("MapSelected", mapNumber);

    }
    public void MapSelected2()
    {
        mapNumber = 2;

        PlayerPrefs.SetInt("MapSelected", mapNumber);
    }



    // Update is called once per frame
    void Update()
    {
    }
}
