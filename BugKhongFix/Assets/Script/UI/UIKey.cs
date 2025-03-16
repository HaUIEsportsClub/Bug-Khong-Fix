using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKey : MonoBehaviour
{
    [SerializeField] private List<Image> listKey;
    [SerializeField] private int keys = 0;
    public int Keys
    {
        get => this.keys;
        set => this.keys = value;
    }

    public void SetKey()
    {
        if (this.keys == 0) return;

        this.listKey[keys - 1].color = Color.white;
      
    }
}
