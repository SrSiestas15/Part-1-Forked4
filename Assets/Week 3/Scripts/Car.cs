using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public GameObject spill;
    public GameObject arrow;
    float acceleration;
    float steering;
    public float forwardSpeed = 600;
    public float steeringSpeed = 40;
    public float maxSpeed = 1000;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering* -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);
        }
    }

    private void OnTriggerEnter2D(Collider2D spill)
    {
        forwardSpeed = 50;
        steeringSpeed = 10;
    }

    private void OnTriggerExit2D(Collider2D spill)
    {
        forwardSpeed = 600;
        steeringSpeed = 40;
    }
}
