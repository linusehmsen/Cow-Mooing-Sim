using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public static SettingsMenu settingsMenu { get; private set; }

    [Header("Audio")]
    public AudioMixer musicMixer;
    public AudioMixer sfxMixer;

    void Awake()
    {
        if (settingsMenu != null && settingsMenu != this)
        {
            Destroy(this);
        }
        else
        {
            settingsMenu = this;
        }
    }

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
