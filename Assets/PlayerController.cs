using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 1;
    public float JumpForce = 1;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0,0);
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            rb.velocity = Vector3.up * JumpForce;
        }
    }



}

