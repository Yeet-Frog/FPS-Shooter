using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plasma_Launching : MonoBehaviour
{
    public GameObject plasma;
    public GameObject spawn;

    public float reloadTime = 0.0f;
    public bool canShoot;



    public float bulletSpeed = 175f;
    public int energy = 500;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;

        
        //StopCoroutine("Reload");
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;
        if (energy == 0)
        {
            canShoot = false;

        }
        if (Input.GetButtonDown("Reload") || energy == 0)
        {
            canShoot = false;

            StartCoroutine("Reload");
            energy = 500;


        }

        if (Input.GetAxis("Fire2") == 1 && canShoot == true)
        {
            GameObject newPlasma = Instantiate<GameObject>(plasma, spawn.transform.position, Quaternion.identity);
            Rigidbody rb = newPlasma.GetComponent<Rigidbody>();
            rb.velocity = transform.right * bulletSpeed * Time.deltaTime;
            energy = energy - 1;
            print(energy);
        }



    }
    
    IEnumerator Reload()
    {
        transform.Rotate(0, 0, 15);
        yield return new WaitForSeconds(2);
        canShoot = true;
        transform.Rotate(0, 0, -15);
    }

}
