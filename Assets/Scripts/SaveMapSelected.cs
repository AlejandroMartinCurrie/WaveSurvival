using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMapSelected : MonoBehaviour
{
    public GameObject map1;
    public GameObject map2;

    public int mapSelected;

    void Start()
    {
        mapSelected = PlayerPrefs.GetInt("MapSelected");
        
    }




    // Update is called once per frame
    void Update()
    {
        if(mapSelected == 1)
        {
            map1.SetActive(true);
        }
        else if (mapSelected == 2)
        {
            map2.SetActive(true);
        }
        
    }
}
