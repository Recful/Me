using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator;
    public float walkSpeed = 40f;
    float horizontalMove = 0f;
    

    // Update is called once per frame
    void Update()
    {
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

    }

    void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime);
	}
}
