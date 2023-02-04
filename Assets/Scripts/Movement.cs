using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed = 1;
    public Rigidbody2D rigidbody;
    public int jumpforce = 200;
    public Animator animator;
    public bool isJump;
    public Transform adsgdd;
    
    void Update()
    {
        Move();
    }

    private void Move()
    {
        RaycastHit2D hit = Physics2D.Raycast(adsgdd.transform.position, -Vector2.up, 0.01f);
        Debug.Log(hit.transform.name);
        if (hit) 
        {
            isJump = false;
        }
        if(Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
            transform.position = new Vector3(transform.position.x + 1 * speed * Time.deltaTime, transform.position.y, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        if(Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Run", true);
            transform.position = new Vector3(transform.position.x - 1 * speed * Time.deltaTime, transform.position.y, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        if(Input.GetKeyDown(KeyCode.W) && isJump == false)
        {
            rigidbody.AddForce(transform.up * jumpforce);
            isJump = true;
        }
    }

    /*private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log(rigidbody.velocity.y + " " + rigidbody.velocity.normalized.y);
        if(other != null && rigidbody.velocity.normalized.y == 0)
        {
            isJump = false;
        }
    }*/

}
