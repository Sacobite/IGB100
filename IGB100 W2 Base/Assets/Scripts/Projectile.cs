using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

public float lifetime = 3.0f;

public float moveSpeed = 350.0f; 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
      Movement();  
    }

    private void Movement()
    {
        transform.position += Time.deltaTime * moveSpeed * transform.forward;
    }
}
