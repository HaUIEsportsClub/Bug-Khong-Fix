using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingMovement : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    [SerializeField] private float timeEnd = 5f;
    [SerializeField] private float moveSpeed = 1.5f;
    [SerializeField] private Button btnHome;
    private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject YouWin;
    private float up = 0f;
    private float right = 0f;
    private void Awake()
    {
        audio.Play();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        btnHome.onClick.AddListener(delegate
        {
            SceneManager.LoadSceneAsync("Home");
        });
    }
    private void Update()
    {
        timeEnd -= Time.deltaTime;
        if(timeEnd > 0)
        {
            Movement();
        }
        else
            YouWin.SetActive(true);
        
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
