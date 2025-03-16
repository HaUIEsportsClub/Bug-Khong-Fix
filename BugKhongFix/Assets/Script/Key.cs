using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private UIKey uikey;
    [SerializeField] private int indexKey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            uikey.Keys++;
            uikey.SetKey(indexKey);

            this.DesTroy();
        }
    }

    public void DesTroy()
    {
        Destroy(gameObject);
    }
}
