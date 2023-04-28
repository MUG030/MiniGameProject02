using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForce : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1.0f;
    [SerializeField] private KeyCode jumpKey = KeyCode.Space;
    private Rigidbody2D rbody;
    private bool canJump = false;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(jumpKey) && !canJump)
        {
            rbody.AddForce(Vector2.up * jumpForce);
            canJump = true;
        }
        else if (canJump)
        {
            Debug.Log("Test");
            canJump = false;
        } 
    }
}
