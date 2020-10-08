using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;

    float inputHori;
    bool jumping;
    public bool grounded; //<== set by GroundedTrigger.cs
    public float moveSpeed = 10f;
    public float jumpSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHori = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && grounded)   //jump is listed as space in the input
        {                                  //manager in project settings
            jumping = true;

        }
    }

    void FixedUpdate()
    {
        playerRB.velocity = new Vector2(inputHori * moveSpeed, playerRB.velocity.y);

        if (jumping)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpSpeed);
            jumping = false;
        }
    }
}
