using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 1;
    public Rigidbody2D rigidbody;
    public int jumpforce = 200;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 1 * speed * Time.deltaTime, transform.position.y, 0);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - 1 * speed * Time.deltaTime, transform.position.y, 0);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            rigidbody.AddForce(transform.up * jumpforce);
        }
    }
}
