using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsInteractionScript : MonoBehaviour
{
    Rigidbody rb;

    void Start()

    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);

        }
    }
}
