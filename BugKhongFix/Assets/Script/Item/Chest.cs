using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private ClickE clickE;
    [SerializeField] private int indexChest;
    public GameObject key;
    private bool isOpen = false;
    private bool isPlayerNear = false;
    private Animator animator;
    [SerializeField] private RuntimeAnimatorController controller;
    [SerializeField] private UIKey uiKey;
    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = null;
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
            if(uiKey.CheckOpen(indexChest))
            {
                isPlayerNear = true;
                clickE.TrueActive(transform.position);
            }

        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerNear = false;
            clickE.FalseActive();
        }
    }

    void OpenChest()
    {
        isOpen = true;
        animator.runtimeAnimatorController = controller;
        clickE.FalseActive();

        if (key != null)
        {
            key.SetActive(true);
        }
    }
}
