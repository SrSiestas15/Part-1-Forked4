using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public GameObject asteroidPrefab;
    public Transform Spawn;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = Color.yellow;
        Instantiate(asteroidPrefab, Spawn.position, Spawn.rotation);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}
