using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextMap : MonoBehaviour
{
    [SerializeField] private UIKey uIKey;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(this.uIKey.Keys == 4)
            {
                SceneManager.LoadSceneAsync("End");
            }
        }
    }
}
