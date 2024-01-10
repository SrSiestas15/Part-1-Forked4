using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 3f;
    public GameObject missilePrefab;
    public Transform Spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(speed*direction*Time.deltaTime, 0, 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab,Spawn.position, Spawn.rotation);
        }
    }
}
