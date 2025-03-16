using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private Button btnAgain;

    private void Start()
    {
        btnAgain.onClick.AddListener(delegate
        {
            SceneManager.LoadSceneAsync("Map1");
        });
        btnBack.onClick.AddListener(delegate
        {
            SceneManager.LoadSceneAsync("Home");
        });
    }
}
