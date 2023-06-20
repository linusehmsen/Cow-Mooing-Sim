using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject cow;

    [Header("Sound")]
    public AudioSource sound1;
    public AudioSource sound2;
    
    [Header("UI")]
    public Canvas gameOverScreen;

    private void Start()
    {
        gameOverScreen.enabled = false;
    }

    
    void Update()
    {
        Show();
    }

    public void FadeSound()
    {
        
    }

    void Show()
    {
        //gameOverScreen.enabled = !cow.activeInHierarchy;
        if (cow.activeInHierarchy != true)
        {
            gameOverScreen.enabled = true;
        }
        if (cow.activeInHierarchy != false)
        {
            gameOverScreen.enabled = false;
        }
    }
    
    public void Retry()
    {
        SceneManager.LoadScene(1);
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
