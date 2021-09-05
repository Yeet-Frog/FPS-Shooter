using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class The_Life_Span_Of_A_Bubble : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet (Clone)")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Capsule(Clone)")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Plasma Ball(Clone)")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Plasma Flames")
        {
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
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
