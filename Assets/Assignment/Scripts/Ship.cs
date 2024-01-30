using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float acceleration;
    float steering;
    public float forwardSpeed = 600;
    public float steeringSpeed = 40;
    public GameObject laserPrefab;
    public Transform Spawn;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, Spawn.position, Spawn.rotation);
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        rigidbody.AddForce(transform.up * acceleration * forwardSpeed * Time.deltaTime);
    }
}
