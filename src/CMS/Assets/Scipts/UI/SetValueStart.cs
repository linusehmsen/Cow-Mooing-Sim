using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetValueStart : MonoBehaviour
{
    [Header("UI")]
    public Slider sfxSlider;
    public Slider musicSlider;

    private void Start()
    {
        sfxSlider.value = sfxSlider.maxValue;
        musicSlider.value = musicSlider.maxValue;
    }
}
