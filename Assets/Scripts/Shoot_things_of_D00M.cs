using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Shoot_things_of_D00M : MonoBehaviour
{
    public GameObject bullet;
    public GameObject spawn;
    public GameObject fpsc;
  
    public float bulletSpeed = 175f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetAxis("Fire2") == 1)
        {
            GameObject newBullet = Instantiate<GameObject>(bullet, spawn.transform.position, Quaternion.identity);
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            rb.velocity = transform.right * bulletSpeed * Time.deltaTime;
            
           
        }
        
        


    }
   
}
