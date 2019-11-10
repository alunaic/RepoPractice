using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnSelf : MonoBehaviour
{
    public float torque; // declare rotation amount
    public float turn;
    public Rigidbody rb; 

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //float turn = Input.GetAxis("Horizontal"); //rotate on input, needs further research
        rb.AddRelativeTorque(Vector3.up * torque * turn);
    }
}