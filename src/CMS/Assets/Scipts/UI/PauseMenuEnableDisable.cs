using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuEnableDisable : MonoBehaviour
{
    public Canvas pauseMenu;


    private void Start()
    {
        pauseMenu.enabled = false;
    }

    public void DisableEnablePauseMenu()
    {
        pauseMenu.enabled = true;
    }
}
