using UnityEngine;
using UnityEngine.UI;

public class FillLevelBar : MonoBehaviour
{
    public Image fillImage;
    public Slider slider;
    public CowCharecter cowCharecter;


    private void Awake()
    {
        
    }


    private void Update()
    {
        var cowCharecter = GameObject.Find("Cow").GetComponent<CowCharecter>();
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }

        if (slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }

        if (slider.value > slider.maxValue)
        {
            slider.value = slider.maxValue;
        }
        int fillValue = cowCharecter.currentExperience / cowCharecter.maxExperience;
        if(fillValue <= slider.maxValue)
        {
            fillImage.color = Color.blue;
        }
        if(fillValue <= 10)
        {
            fillImage.color = Color.red;
        }
        if(fillValue >= 30)
        {
            fillImage.color = Color.yellow;
        }
        if(fillValue < 30)
        {
            fillImage.color = Color.green;
        }
        slider.value = fillValue;
    }
}
