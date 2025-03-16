 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    //[SerializeField] private List<AudioClip> listSound;
    [SerializeField] private AudioSource soundRun;
    [SerializeField] private AudioSource soundBackGround;
    [SerializeField] private AudioSource soundKey;
 
    [SerializeField] private AudioSource soundCLock;
    [SerializeField] private AudioSource soundRoom;

    private void Start()
    {
        SoundManager.Instance.PlaySoundBack();
    }
    public void PlaySoundBack()
    {
        soundBackGround.Play();
        soundCLock.Play();
    }

    public void PlayRunning()
    {
        soundRun.Play();
    }

    public void StopRunning()
    {
        soundRun.Stop();
    }
}
