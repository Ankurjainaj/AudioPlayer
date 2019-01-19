using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] AudioClips;
    AudioSource AudioSource;
    public int CurrentTrack = 0;
    bool IsPlaying = false;
    public Text Songname;
    public Slider Progress;
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.clip = AudioClips[CurrentTrack];
    }

    // Update is called once per frame
    void Update()
    {
        Songname.text = AudioClips[CurrentTrack].name;
        Progress.maxValue = AudioClips[CurrentTrack].length;
        Progress.value = AudioSource.time;
    }
    public void Play()
    {
        AudioSource.Play();
        IsPlaying = true;
    }
    public void Pause()
    {
        AudioSource.Pause();
        IsPlaying = false;
    }
    public void Stop()
    {
        AudioSource.Stop();
    }
    public void Mute()
    {
        AudioSource.mute= true;
    }
    public void UnMute()
    {
        AudioSource.mute = false;
    }
    public void Next()
    {
        Stop();
        if (CurrentTrack == AudioClips.Length-1)
            CurrentTrack = 0;
        else
            CurrentTrack++;
        AudioSource.clip = AudioClips[CurrentTrack];
        if (IsPlaying)
            Play();
    }
    public void Prev()
    {
        Stop();
        if (CurrentTrack == 0)
            CurrentTrack = AudioClips.Length - 1;
        else
            CurrentTrack--;
        AudioSource.clip = AudioClips[CurrentTrack];
        if (IsPlaying)
            Play();
    }
}
