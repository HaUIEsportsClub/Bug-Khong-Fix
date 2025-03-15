using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHome : MonoBehaviour
{
    [SerializeField] private Button btnPlay;
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        audioSource.Play();

        btnPlay.onClick.AddListener(delegate
        {
            SceneManager.LoadSceneAsync("Map1");
        });
    }
    
}
