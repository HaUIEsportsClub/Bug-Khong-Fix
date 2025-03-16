using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISetting1 : MonoBehaviour
{
    [SerializeField] private GameObject menuSetting;
    [SerializeField] private Button btnPause;
    [SerializeField] private Sprite imagePause;
    [SerializeField] private Sprite imageContinue;
    public bool isPause;
    private void Start()
    {
        btnPause.onClick.AddListener(delegate
        {
            GameController.Instance.GamePause();
            menuSetting.SetActive(true);
            isPause = true;
        });
    }
    private void Update()
    {
        checkPause();  
    }
    public void checkPause()
    {

        if (!isPause)
            btnPause.GetComponent<Image>().sprite = imageContinue;
        else
            btnPause.GetComponent<Image>().sprite = imagePause;
    }
}
