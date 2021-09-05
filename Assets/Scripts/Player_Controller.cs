using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {
    public GameObject[] guns;
    
    
    public float speed = 0.0f;
    public float rotationSpeed = 0.0f;
    public float jumpHeight = 0.0f;
    int health = 100;
    int i = 1;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Capsule(Clone)")
        {
            health = health - i++;
            print("Health is at " + health);
        }
    }
    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Rotation");
        float jump = Input.GetAxis("Jump");
        Vector3 movement = new Vector3(horizontal, 0, vertical);
        transform.position += movement * speed * Time.deltaTime;
        Vector3 jumping = new Vector3(0, jump, 0);
        transform.position += jumping * jumpHeight;
        transform.Rotate(0, rotation * Time.deltaTime * rotationSpeed, 0); 
        
    }
 }
