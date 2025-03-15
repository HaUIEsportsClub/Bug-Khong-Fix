using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickE : MonoBehaviour
{
    [SerializeField] private GameObject clickE;

    public void TrueActive(Vector3 pos)
    {
        clickE.SetActive(true);
        this.SetPosition(pos);
    }

    public void FalseActive()
    {
        clickE.SetActive(false);
 
    }

    public void SetPosition(Vector3 pos)
    {
        clickE.transform.position = pos;
    }

}
