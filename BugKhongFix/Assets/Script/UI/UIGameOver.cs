using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
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
            //SceneManager.L
        });
        btnBack.onClick.AddListener(delegate
        {
            SceneManager.LoadSceneAsync("Home");
        });
    }
}
