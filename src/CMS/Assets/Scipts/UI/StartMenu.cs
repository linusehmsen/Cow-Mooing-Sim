using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [Header("UI")]
    public Canvas startMenu;

    private void Start()
    {
        startMenu.enabled = true;
    }

    public void StartBT()
    {
        startMenu.enabled = false;
    }
}
