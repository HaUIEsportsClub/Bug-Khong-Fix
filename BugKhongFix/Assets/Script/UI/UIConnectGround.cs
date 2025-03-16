using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIConnectGround : MonoBehaviour
{
    [SerializeField] private Button btnBack;
    [SerializeField] private GameObject connectMenu;
    [SerializeField] private PlayerMovement player;
    [SerializeField] private List<GameObject> listRoom;

    private void Update()
    {
        btnBack.onClick.AddListener(delegate
        {
            connectMenu.SetActive(false);
        });

    }

    public void CheckPosPlayer()
    {
        for(int i = 0; i < listRoom.Count; i++)
        {
            listRoom[i].transform.GetChild(0).GetComponent<Image>().color = Color.red;
        }
        if (player.IndexPlayer < 1) return;
        listRoom[player.IndexPlayer - 1].transform.GetChild(0).GetComponent<Image>().color = Color.green;
    }
}
