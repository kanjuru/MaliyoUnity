using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpinX : MonoBehaviour
{
    private float speed = 1500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spin the plane's propeller
        transform.Rotate(Vector3.forward * Time.fixedDeltaTime * speed);
    }
}
