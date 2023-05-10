using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator anim;

    public float speed = 5.0f;
    public float jumpForce = 300.0f;

    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask isGroundLayer;
    public float groundCheckRadius = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        if (speed <= 0) speed = 5.0f;
        if (jumpForce <= 0) jumpForce = 300.0f;
        if (groundCheckRadius <= 0) groundCheckRadius = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
