using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private ClickE clickE;
    public GameObject key;
    private bool isOpen = false;
    private bool isPlayerNear = false;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (isPlayerNear && !isOpen && Input.GetKeyDown(KeyCode.E))
        {
            OpenChest();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerNear = true;
            //clickE.TrueActive(transform.position);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerNear = false;
            //clickE.FalseActive();
        }
    }

    void OpenChest()
    {
        isOpen = true;
        animator.SetBool("isOpen", true);
        Debug.Log("Opened Chest!");

        if (key != null)
        {
            key.SetActive(true);
        }
    }
}
