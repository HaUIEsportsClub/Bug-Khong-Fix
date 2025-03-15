using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private bool isNearPlayer = false;
    [SerializeField] private ClickE clickE;
    private void Update()
    {
        this.Pickup();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isNearPlayer = true;
            //clickE.TrueActive(transform.position);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isNearPlayer = false;
            //clickE.FalseActive();
        }
    }

    protected virtual void Pickup()
    {
        if (isNearPlayer && Input.GetKeyDown(KeyCode.E))
        {
            TimeManager.Instance.currentTime += 30f;
            Destroy(gameObject);
        }
    }
}
