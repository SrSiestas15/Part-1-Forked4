using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    public float force = 10f;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
    }
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
}
