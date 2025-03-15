using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] public float startTime = 135f;
    [SerializeField] public float currentTime;
    [SerializeField] public int minutes;
    [SerializeField] public float seconds;
    [SerializeField] private TextMeshProUGUI textTime;
    public static TimeManager instance;

    private void Awake()
    {
        TimeManager.instance = this;

        currentTime = startTime;
        LoadTime();
    }
    

    protected void LoadTime()
    {
        minutes = (int)startTime / 60;
        seconds = (int)(startTime - minutes * 60);
    }
    protected void CalculateTime()
    {
        if (seconds <= 0) return;
        seconds -= Time.deltaTime;
        if (seconds <= 0)
        {
            minutes -= 1;
            seconds = 60;
        }
    }

    public void UpdataTime()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        else
        {
        }
        CalculateTime();

        textTime.text = this.minutes + " : " + (int)this.seconds;
    }
    private void Update()
    {
        this.UpdataTime();

    }

}
