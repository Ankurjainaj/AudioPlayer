using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    public GameObject PlayButton;
    public GameObject PauseButton;
    public GameObject MuteButton;
    public GameObject UnMuteButton;
    public GameObject NextButton;
    public GameObject PrevButton;
    public GameObject MusicManager;
    // Use this for initialization
    void Start () {
        PlayButton.SetActive(true);
        PauseButton.SetActive(false);
        MuteButton.SetActive(true);
        UnMuteButton.SetActive(false);
        PrevButton.SetActive(true);
        NextButton.SetActive(true);

    }
	
	// Update is called once per frame
	//i would recommend to use the unity's latest version.
	void Update () {
		
	}
    public void Play()
    {
        PlayButton.SetActive(false);
        PauseButton.SetActive(true);
        MusicManager.SendMessage("Play the song", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Pause()
    {
        PlayButton.SetActive(true);
        PauseButton.SetActive(false);
        MusicManager.SendMessage("Pause the song and wait", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Mute()
    {
        MuteButton.SetActive(false);
        UnMuteButton.SetActive(true);
        MusicManager.SendMessage("Mute the song amd wait", null, SendMessageOptions.DontRequireReceiver);
    }
    public void UnMute()
    {
        UnMuteButton.SetActive(false);
        MuteButton.SetActive(true);
        MusicManager.SendMessage("UnMute the song", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Next()
    {
        MusicManager.SendMessage("Play the next song", null, SendMessageOptions.DontRequireReceiver);
    }
    public void Prev()
    {
        MusicManager.SendMessage("Play the previous song", null, SendMessageOptions.DontRequireReceiver);
    }
}
