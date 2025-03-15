using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private bool isNearPlayer = false;
    [SerializeField] TimeManager timeManager;

    private void Update()
    {
        this.Pickup();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) isNearPlayer = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) isNearPlayer = false;
    }

    protected virtual void Pickup()
    {
        if (isNearPlayer && Input.GetKeyDown(KeyCode.E))
        {
            timeManager.currentTime += 30f;
            Destroy(gameObject);
        }
    }
}
