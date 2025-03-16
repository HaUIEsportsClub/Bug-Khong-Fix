using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISetting1 : MonoBehaviour
{
    [SerializeField] private GameObject menuSetting;
    [SerializeField] private Button btnPause;

    private void Start()
    {
        btnPause.onClick.AddListener(delegate
        {
            GameController.Instance.GamePause();
            menuSetting.SetActive(true);
        });
    }
}
