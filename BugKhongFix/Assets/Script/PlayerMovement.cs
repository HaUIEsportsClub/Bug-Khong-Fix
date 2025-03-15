using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
 
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.velocity = playerInput.normalized * moveSpeed * Time.deltaTime;
        if (playerInput != Vector2.zero)
        {
            animator.SetBool("isRunning", true);
            animator.SetFloat("moveX", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("moveY", Input.GetAxisRaw("Vertical"));
        }
        if (playerInput != Vector2.zero) animator.SetBool("isRunning", true);
        else animator.SetBool("isRunning", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Door"))
        {
            if(collision.TryGetComponent(out Door door))
            {
                transform.position = door.PositionDoorConnect(gameObject);
            }
        }
        /*if (collision.CompareTag("Chest"))
        {

        }*/
    }
}
