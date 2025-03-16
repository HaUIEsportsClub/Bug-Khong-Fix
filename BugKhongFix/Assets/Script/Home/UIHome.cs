using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHome : MonoBehaviour
{
    [SerializeField] private Button btnPlay;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private Slider slider;
    [SerializeField] private float duration;
    [SerializeField] private GameObject loading;
    private const float maxValueSlider = 100f;
    private float value = 0f;
    private Tweener tweener;

    private void Awake()
    {
        audioSource.Play();
        slider.maxValue = maxValueSlider;
    }
    private void Update()
    {
        btnPlay.onClick.AddListener(delegate
        {
            loading.SetActive(true);
            slider.gameObject.SetActive(true);
            StartLoading();
        });
    }

    public void StartLoading()
    {
        btnPlay.gameObject.SetActive(false);
        if (tweener != null && tweener.IsPlaying())
            tweener.Kill();

        tweener = DOTween.To(() => value, x => value = x, maxValueSlider, duration)
            .OnUpdate(() => slider.value = value)
            .OnComplete(() =>
            {
                SceneManager.LoadSceneAsync("Map1");
            });
    }

    public void ResetSlider()
    {
        if (tweener != null && tweener.IsPlaying())
            tweener.Kill();

        value = 0f;
        slider.value = value;
    }
}
