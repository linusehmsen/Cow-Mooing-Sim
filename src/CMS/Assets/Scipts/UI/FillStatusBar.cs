using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public Health playerHealth;
    public Image fillImage;
    private Slider slider;


    void Awake()
    {
        slider = GetComponent<Slider>();
    }
    
    // Update is called once per frame
    void Update()
    {
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
        
        float fillValue = playerHealth.currentHealth / playerHealth.maxHealth;
        if(fillValue <= slider.maxValue / 5)
        {
            fillImage.color = Color.red;
        }
        else if(fillValue > slider.maxValue / 5)
        {
            fillImage.color = Color.red;
        }

        slider.value = fillValue;
    }
}
