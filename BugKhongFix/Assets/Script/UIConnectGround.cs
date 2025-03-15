using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIConnectGround : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private GameObject connectMenu;

    private void Update()
    {
        btnBack.onClick.AddListener(delegate
        {
            connectMenu.SetActive(false);
        });

    }
}
