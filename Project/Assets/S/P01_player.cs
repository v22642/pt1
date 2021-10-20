using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using UnityEngine;

public class P01_player : MonoBehaviour
{
    public float speed;
    public float jampY;
    private float moveX;

    private Rigidbody2D rb;
    private Animator anim;

    private bool faceRight = true;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private void Start ()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * speed, rb.velocity.y);
        
        if (moveX > 0 && !faceRight)
            flip();
        else if (moveX < 0 && faceRight)
            flip();
        if(moveX == 0)
        {
            anim.SetBool("Ran", false);
        }
        else
        {
            anim.SetBool("Ran", true);
        }
        
    }
    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position,checkRadius,whatIsGround);
        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce ( Vector2.up*jampY);
            anim.SetTrigger("cl");
        }
        if (isGrounded == true)
        {
            anim.SetBool("Jamp", false);
        }
        else
        {
            anim.SetBool("Jamp", true);
        }
    }
    void flip()
    {
        faceRight = !faceRight; 
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y);
    }
}

    
    



 /*   public float speed;
    private Rigidbody2D r;
    private bool faceRight = true;
    void Start() => r = GetComponent<Rigidbody2D>();


    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        r.MovePosition(r.position + Vector2.right * moveX * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
            r.AddForce(Vector2.up * 8000);
      
 */

