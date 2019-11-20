using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMover : MonoBehaviour
{
    public Joystick joystick;
    public float speed = 10f;
    public Transform box;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotX = joystick.Horizontal * speed;
        float rotY = joystick.Vertical * speed;

        transform.Rotate(rotX, rotY, 0);
    }
}
