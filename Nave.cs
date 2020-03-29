using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float torque = 1f;
    public float force = 5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddTorque ((force * torque) * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddTorque ((-force * torque) * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddRelativeForce(Vector3.up * (-force / 100), ForceMode2D.Impulse);
        }

    }
}