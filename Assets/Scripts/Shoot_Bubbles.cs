using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Bubbles : MonoBehaviour
{
    public GameObject bubble;
    public GameObject spawn;
    public float bubbleSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Fire1") == 1)
        {
            GameObject newBubble = Instantiate<GameObject>(bubble, spawn.transform.position, Quaternion.identity);
            Rigidbody rb = newBubble.GetComponent<Rigidbody>();
            //rb.AddForce(transform.up * 500);
            rb.velocity = transform.up * bubbleSpeed * Time.deltaTime;
        }

    }

}
