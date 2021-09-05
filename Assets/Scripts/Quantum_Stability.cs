using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quantum_Stability : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
       
    Destroy(gameObject);
    }
    // Start is called before the first frame update
    float timer = 0.0f;
    public float Stability = 0.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= Stability)
        {
            Destroy(gameObject);
        }
    }
}
