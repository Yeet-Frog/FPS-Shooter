using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting_hand_gun : MonoBehaviour
{ 

    public GameObject bullet;
    public GameObject spawn;
    public bool canShoot;
    public bool running;
    public int bullets = 5;
    public float bulletSpeed = 175f;
    public GameObject topGun;
// Start is called before the first frame update
    void Start()
    {
        canShoot = true;
    }

// Update is called once per frame
    void Update()
    {
        if (bullets == 0)
        {
            canShoot = false;
            StartCoroutine("reloading");
        }
        if (Input.GetButtonDown("Reload") && running == false)
        {
            canShoot = false;
            StartCoroutine("reloading");
        }
        if (Input.GetAxis("Fire2") == 1 && canShoot == true)
        {
            GameObject newBullet = Instantiate<GameObject>(bullet, spawn.transform.position, Quaternion.identity);
            Rigidbody rb = newBullet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * bulletSpeed * Time.deltaTime;

            StartCoroutine("shootingDelay");
            bullets = bullets - 1;
            print(bullets);
        }




    }
       IEnumerator shootingDelay()
        {
            
            canShoot = false;
            yield return new WaitForSeconds(1.0f);
            canShoot = true;
            

    }
        IEnumerator reloading()
        {
            running = true;
            topGun.transform.position -= transform.forward / 75;
            yield return new WaitForSeconds(2.0f);
            canShoot = true;
            bullets = 5;
            topGun.transform.position += transform.forward / 75;
            running = false;
    }

}