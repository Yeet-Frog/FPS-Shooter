using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swarm_Controller : MonoBehaviour
{
    public GameObject pill;
    public int swarm;
    // Start is called before the first frame update
    void Start()
    {
        for (int b = 0; b < swarm; b++)
        {
            Instantiate(pill);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }

}