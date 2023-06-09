using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowCharecter : MonoBehaviour
{
    public int currentExperience;
    public int maxExperience;
    public int currentLevel;

    private void OnEnable()
    {
        ExperienceManager.Instance.OnExperienceChange += HandleExperienceChange;
    }

    private void OnDisable()
    {
        ExperienceManager.Instance.OnExperienceChange -= HandleExperienceChange;
    } 

    void HandleExperienceChange(int newExperience)
    {
        currentExperience += newExperience;
        if(currentExperience >= maxExperience)
        {
            //var cowHealth = GetComponent<Health>();
            //cowHealth.LevelUp();
            //LevelUpCow();
        }
    }
    
    void LevelUpCow()
    {
        currentLevel++;

        currentExperience = 0;
        maxExperience += 100;
    }
}
