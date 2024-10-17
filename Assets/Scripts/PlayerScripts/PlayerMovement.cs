using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField]private float speed;
    private BoxCollider2D boxCollider;
    private void Awake()
    {
        //Grab refrences
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);


        //flip the character 
        if(horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(1.5f,1.5f,1);
        }else if(horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1.5f,1.5f,1);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded())
            Jump();

        //set animation 
        anim.SetBool("run",horizontalInput !=0); // check whether there is a horizontal input or not
        anim.SetBool("grounded", isGrounded());
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("jump");
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size,0,Vector2.down,0.1f,groundLayer); 
        return raycastHit.collider != null;
    }
}
