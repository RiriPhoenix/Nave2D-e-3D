using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip3D : MonoBehaviour
{
    public float torque = 10f;
    public float force = 50f;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddTorque(force * Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddTorque(-force * Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(Vector3.up * (force / 500), ForceMode.Impulse);
        }

    }
}