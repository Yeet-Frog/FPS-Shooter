using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Switching : MonoBehaviour
{
    public Camera fpc;
    public Camera scope;

    // Start is called before the first frame update
    void Start()
    {
        fpc.enabled = true;
        scope.enabled= false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("Scope"))
        {
            fpc.enabled = false;
            scope.enabled = true;
        } else
        {
            fpc.enabled = true;
            scope.enabled = false;
        }
    }
}
