using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Level : MonoBehaviour
{
    public GameObject[] guns;
    public int currentGun;
    float previousValue;
    // Start is called before the first frame update
    void Start()
    {
        currentGun = 0;
        //previousValue = Input.GetAxis("Mouse ScrollWheel") * 10;
    }

    // Update is called once per frame
    void Update()
    {
        //float value = Input.GetAxis("Mouse ScrollWheel") * 10;
        //if value is greater than previousValue currentGun++
        //if value is less than previousValue currentGun--
        //set previousValue to value
        //set guns[currentGun] to active
        if (Input.GetKeyUp(KeyCode.E))
        {
            currentGun = currentGun + 1;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            currentGun = currentGun - 1;
        }
        if(currentGun == -1)
        {
            currentGun = 2;
        }
        if(currentGun == 3)
        { 
            currentGun = 0;
        }
        /* if(value < 0)
         {
             value = 2;
         }
         if (value > 2)
         {
             value = 0;
         }
         if (value > previousValue)
         {
             currentGun++;
             previousValue = value;
         }
         if (value < previousValue)
         {
             currentGun--;
             previousValue = value;
         }*/
         if(currentGun != 0)
         {
             guns[0].SetActive(false);
         }
         if (currentGun != 1)
         {
             guns[1].SetActive(false);
         }
         if (currentGun != 2)
         {
             guns[2].SetActive(false);
         }
        
        
        guns[currentGun].SetActive(true);
        print(Input.GetKeyUp(KeyCode.E));
    }
}
