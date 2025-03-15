using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : Singleton<TimeManager>
{
    [SerializeField] public float startTime = 135f;
    [SerializeField] public float currentTime;

    [SerializeField] public int minutes;
    [SerializeField] public float seconds;
    [SerializeField] private TextMeshProUGUI textTime;

    private void Awake()
    {
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
        if (currentTime <= 0) return;

        minutes = (int)currentTime / 60;
        seconds = (int)(currentTime - minutes * 60);
    }

    public void UpdataTime()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        CalculateTime();

        textTime.text = this.minutes + " : " + (int)this.seconds;
    }
    private void Update()
    {
        this.UpdataTime();
    }

    public bool checkGameOver()
    {
        return this.currentTime <= 0;
    }
}
