using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTransform : MonoBehaviour
{

    public float y_speed = 0.5f;  //apply speed and make public in inspector

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, y_speed, 0);  //transform object rotation on Y-axis

    }
}
