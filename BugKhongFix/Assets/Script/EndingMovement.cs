using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1.5f;
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private float up = 0f;
    private float right = 0f;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        if (transform.position.y <= 19.5f) up += Time.deltaTime;
        else right += Time.deltaTime;

        Vector2 player = new Vector2(right, up);
        rb.velocity = player.normalized * moveSpeed;

        if (player != Vector2.zero)
        {
            animator.SetBool("isRunning", true);
            animator.SetFloat("moveX", right);
            animator.SetFloat("moveY", up);
        }
        if (player != Vector2.zero)
        {
            animator.SetBool("isRunning", true);
        }

        else animator.SetBool("isRunning", false);
        right = up = 0f;
    }
}
