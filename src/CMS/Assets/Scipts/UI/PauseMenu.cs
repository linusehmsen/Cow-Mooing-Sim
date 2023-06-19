using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [Header("UI")]
    public Canvas pauseMenu;

    [System.Obsolete]
    private void Start()
    {
        pauseMenu.enabled = false;
    }

    private void Update()
    {
        EnablePauseMenu();
    }
    
    void EnablePauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            pauseMenu.enabled = false;
        }
    }

    public void ResumeGame()
    {
        pauseMenu.enabled = false;
    }
    
    public void EnterMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
