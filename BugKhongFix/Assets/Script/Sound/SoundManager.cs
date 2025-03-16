 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{

    [SerializeField] private AudioSource soundBackGround;
    [SerializeField] private AudioSource soundCLock;


    [SerializeField] private AudioClip audioKey;
    private void Start()
    {
        SoundManager.Instance.PlaySoundBack();
    }
    public void PlaySoundBack()
    {
        soundBackGround.Play();
        soundCLock.Play();
    }


}
