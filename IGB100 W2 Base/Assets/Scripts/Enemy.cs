using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float moveSpeed = 15.0f;

    public float health = 100.0f;

    public float damage = 25.0f;
    private float damageRate = 0.2f;
    private float damageTime;

    public GameObject deathEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    //Enemy Movement - beeline for player
    private void Movement() {
        if(GameManager.instance.Player)
            transform.LookAt(GameManager.instance.Player.transform.position);

        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }

}
