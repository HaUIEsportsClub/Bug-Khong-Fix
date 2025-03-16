using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UISetting : MonoBehaviour
{
    [SerializeField] private GameObject menuSetting;
    [SerializeField] private Button btnContinue;
    [SerializeField] private Button btnAgain;
    [SerializeField] private Button btnBack;
    [SerializeField] private UISetting1 uisetting1;
    private void Start()
    {
        btnContinue.onClick.AddListener(delegate
        {
            GameController.Instance.GameContinue();
            menuSetting.SetActive(false);
            uisetting1.isPause = false;
            uisetting1.checkPause();

        });
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
