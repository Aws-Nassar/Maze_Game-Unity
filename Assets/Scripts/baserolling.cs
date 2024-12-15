using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baserolling : MonoBehaviour
{
    public float rotationalSpeed = 12f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizintalMov = Input.GetAxisRaw("Horizontal");

        if (horizintalMov == 0)
        {
            rb.Sleep();
        }
        else 
        {
            rb.WakeUp();
        }

        rb.AddTorque(Vector3.back * horizintalMov * rotationalSpeed * Time.deltaTime, ForceMode.Acceleration);
    }
}
