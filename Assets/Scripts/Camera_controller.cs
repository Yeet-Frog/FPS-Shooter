using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 */
public class Camera_controller : MonoBehaviour {
    public float rotationSpeed = 0.0f;
    public GameObject player;
      
    // Use this for initialization 
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float looking = Input.GetAxis("Looking");
        //transform.Rotate(looking * Time.deltaTime * rotationSpeed, 0, 0);

        /* if (looking >= 20f)
         {
              rotationSpeed = 0.0f;

             //transform.Rotatew Vector3(1, 0, 0) * rotationSpeed);
         }
             rotationSpeed = 1f;
         if (looking <= -20f)
         {
              rotationSpeed = 0.0f;
             //transform.Rotate(new Vector3(-1, 0, 0) * rotationSpeed);
         }
             rotationSpeed = 1f;


         if (looking >= -20f && looking <= 20f) rotationSpeed = 1f;
         else rotationSpeed = 0f;
         print(looking);
         
        if (looking > 75f || looking < -75f)
        {
            head.transform.eulerAngles -= new Vector3(transform.eulerAngles.x, 0f, 0f) * rotationSpeed * Time.deltaTime * mouseSensitivity;
        eolse
        {
            head.transform.eulerAngles += new Vector3(transform.eulerAngles.x, 0f, 0f) * rotationSpeed * Time.deltaTime * mouseSensitivity;
        }
     */
     
     Vector3 cameraFacing = transform.forward;
     Vector3 playerFacing = player.transform.forward;
     float angle = Vector3.Angle(playerFacing, cameraFacing);

        if (angle > 50 || angle < -50)
        {
            transform.eulerAngles -= new Vector3(angle, 0f, 0f) * rotationSpeed * Time.deltaTime;
        }
        else
        {
            transform.eulerAngles += new Vector3(looking, 0f, 0f) * rotationSpeed * Time.deltaTime;
        }



    }
}
