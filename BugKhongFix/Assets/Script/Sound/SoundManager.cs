using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : Singleton<SoundManager>
{
    [SerializeField] private List<AudioClip> listSound;
    [SerializeField] private AudioSource audioSound;
    [SerializeField] private AudioSource soundBackGround;

    public List<AudioClip> ListSound
    {
        get => this.listSound;
    }
    private void Start()
    {
        SoundManager.Instance.PlaySoundBack();

    }
    public void PlaySoundBack()
    {
        soundBackGround.Play();
    }
    public void PlayOneSound(AudioClip clip)
    {

        audioSound.PlayOneShot(clip);
    }
}
