using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    [Header("Audio")]
    public AudioMixer musicMixer;
    public AudioMixer sfxMixer;
    
    public void FullScreen(bool isFullsceen)
    {
        Screen.fullScreen = isFullsceen;
    }

    public void SetMusicVolume(float musicVolume)
    {
        musicMixer.SetFloat("Music", musicVolume);
    }

    public void SetSFXVolume(float sfxVolume)
    {
        sfxMixer.SetFloat("SFX", sfxVolume);
    }
}
