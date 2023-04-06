using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    private Vector3 position; 

    public GameObject projectile;
    public float fireRate = 0.1f;
    private float fireTime; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = transform.position; 

        Movement();
        Boundary();

        transform.position = position;

        Shoot();

    }

    private void Shoot() {
        if(Input.GetKey("space") && Time.time > fireTime) {
            Instantiate(projectile, transform.position, transform.rotation);
            fireTime = Time.time + fireRate;
        }
    }

    //Player Input Controls
    private void Movement(){
        //Right Movement
        if (Input.GetKey("d"))
            position.x +=moveSpeed * Time.deltaTime;

        //Left movement
        if (Input.GetKey("a"))
            position.x -=moveSpeed * Time.deltaTime;

        //Up movement
        if (Input.GetKey("w"))
            position.z +=moveSpeed * Time.deltaTime;

        //Down movement
        if (Input.GetKey("s"))
            position.z -=moveSpeed * Time.deltaTime;
    }

    private void Boundary() {
            //X Boundary Checks
            if (position.x > GameManager.instance.xBoundary)
                position.x = GameManager.instance.xBoundary;
            else if (position.x < -GameManager.instance.xBoundary)
                position.x = - GameManager.instance.xBoundary;

            //Y Boundary Checks
            if (position.z > GameManager.instance.zBoundary)
                position.z = GameManager.instance.zBoundary;
            else if (position.z < -GameManager.instance.zBoundary)
                position.z = - GameManager.instance.zBoundary;
    }
}
