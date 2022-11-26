using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public string horizontalInputName = "Horizontal_P1";
    public string verticalInputName = "Vertical_P1";
    public string interactInputName = "Interact_P1";
    
    
    private Rigidbody2D rb;
    private float horizontalInput;
    private float verticalInput;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw(horizontalInputName);
        verticalInput = Input.GetAxisRaw(verticalInputName);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }
}

