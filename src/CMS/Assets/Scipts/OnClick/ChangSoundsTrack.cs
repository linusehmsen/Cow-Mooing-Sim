using UnityEngine;

public class ChangSoundsTrack : MonoBehaviour
{
    [Header("AudioSources")]
    public AudioSource sound1;
    public AudioSource sound2;

    void Update()
    {
        PlayBackGroundMusic();
    }

    void PlayBackGroundMusic()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            sound1.Stop();
            sound2.Play();
        }
        if (Input.GetKey(KeyCode.U))
        {
            sound2.Stop();
            sound1.Play();
        }
    }
}
