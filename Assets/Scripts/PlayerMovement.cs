using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    bool isFacingRight;

    [Space][Header("Movement and jump")]
    float horizontal;
    [SerializeField] float speed = 6f;
    [SerializeField] float jumpForce = 10f;
    //Coyote Time variaables
    float coyoteTime = 0.2f;
    float coyoteTimeCounter;
    //Jump buffering
    float jumpBufferTime = 0.2f;
    float jumpBufferCounter;

    [Space][Header("Ground")]
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    Rigidbody2D playerRigid;
    CapsuleCollider2D playerCollider;

    void Start() {
        
        playerRigid = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update() {
        
        horizontal = Input.GetAxisRaw("Horizontal");

        //Coyote time implementation
        if(IsGrounded()){
            coyoteTimeCounter = coyoteTime;
        }else{
            coyoteTimeCounter -= Time.deltaTime;
        }

        //Jump buffering implementation
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)){

            jumpBufferCounter = jumpBufferTime;
            Debug.Log("Up arrow pressed");
        }else{

            jumpBufferCounter -= Time.deltaTime;
        }

        //Activate Jump if player is in the ground and the key is pressed
        if(coyoteTimeCounter > 0f && jumpBufferCounter > 0){

            playerRigid.velocity = new Vector2(playerRigid.velocity.x, jumpForce);
            jumpBufferCounter = 0;
        }

        //Let us jump higher while we most pess JUMP button
        if(Input.GetKeyDown(KeyCode.UpArrow) && playerRigid.velocity.y > 0f){

            playerRigid.velocity = new Vector2(playerRigid.velocity.x, playerRigid.velocity.y * 0.5f);
            coyoteTimeCounter = 0f;
        }

        Flip();
    }

    void FixedUpdate() {
        
        playerRigid.velocity = new Vector2(horizontal * speed, playerRigid.velocity.y);
    }

    bool IsGrounded(){

        float extraHeighText = 0.1f;
        RaycastHit2D raycastHit = Physics2D.Raycast(playerCollider.bounds.center, Vector2.down, 
            playerCollider.bounds.extents.y + extraHeighText, groundLayer);
        Color rayColor;
        if(raycastHit.collider != null){

            rayColor = Color.green;
        }else{

            rayColor = Color.red;
        }

        Debug.DrawRay(playerCollider.bounds.center, 
            Vector2.down * (playerCollider.bounds.extents.y + extraHeighText), rayColor);

        return raycastHit.collider != null;
    }

    void Flip(){

        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f){

            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    
}