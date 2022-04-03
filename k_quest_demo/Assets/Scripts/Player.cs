// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Player : MonoBehaviour
// {
//     public float speed;
//     // public Joystick joystick;
//     public Rigidbody2D rb;
//     private Vector2 moveInput;
//     private Vector2 moveVelocity;
   
//     private void Update()
//     {
//         moveInput = new Vector2 (joystick.Horizontal, joystick.Vertical);
//         moveVelocity = moveInput.normalized * speed;
//     }

//     private void FixedUpdate()
//     {
//         rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
//     } 
// }
