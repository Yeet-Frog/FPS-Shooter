using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_Of_A_Round : MonoBehaviour
{
    float timer = 0.0f;
    public float lifeSpan = 0.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}
