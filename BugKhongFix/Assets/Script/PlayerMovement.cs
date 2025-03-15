using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG;

using DG.Tweening;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    private int indexPlayer = 1;

    public int IndexPlayer
    {
        get => this.indexPlayer;
    }
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
        //SoundManager.instance.PlayOneSound(SoundManager.instance.ListSound[4]);
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
                if (door.DoorConnect == null) return;

                transform.DOScale(Vector3.zero, 0.05f);
                this.indexPlayer = door.DoorConnect.IndexRoom;
                transform.DOScale(Vector3.one, 0.05f);
                
            }
        }
    }
}
