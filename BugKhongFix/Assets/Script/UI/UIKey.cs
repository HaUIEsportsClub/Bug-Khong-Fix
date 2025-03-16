using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKey : MonoBehaviour
{
    [SerializeField] private List<Image> listKey;
    [SerializeField] private int keys = 0;
    [SerializeField] private List<bool> isIndex;

    public int Keys
    {
        get => this.keys;
        set => this.keys = value;
    }

    public void SetKey(int indexkey)
    {
        if (this.keys == 0) return;

        this.listKey[indexkey - 1].color = Color.white;

        isIndex[indexkey] = true;
    }
    public bool CheckOpen(int indexchest)
    {
        return isIndex[indexchest];
    }
}
