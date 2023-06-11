using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangSoundsTrack : MonoBehaviour
{
    public AudioSource Sound1;
    public AudioSource Sound2;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Sound1.Stop();
            Sound2.Play();
        }
        if (Input.GetKey(KeyCode.U))
        {
            Sound2.Stop();
            Sound1.Play();
        }
    }
}
