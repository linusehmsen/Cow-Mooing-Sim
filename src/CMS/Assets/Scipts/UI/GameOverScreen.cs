using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject cow;

    [Header("Canvas")]
    public Canvas gameOverScreen;

    
    
    private void Start()
    {
        gameOverScreen.enabled = false;
    }

    
    void Update()
    {
        Show();
    }

    
    void Show()
    {
        gameOverScreen.enabled = !cow.activeInHierarchy;
        //if (cow.activeInHierarchy != true)
        //{
        //    gameOverScreen.enabled = true;
        //}
        //if (cow.activeInHierarchy != false)
        //{
        //    gameOverScreen.enabled = false;
        //}
    }
    
    public void Retry()
    {
        SceneManager.LoadScene(1);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
