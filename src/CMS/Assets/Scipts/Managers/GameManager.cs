using UnityEngine;
using TMPro;
using System.Collections.Generic;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager { get; private set; }

    [Header("GameObjects")]
    public GameObject cow;
    public GameObject gameOverScreenGameObject;

    [Header("Score" + "Text" + "Component")]
    public TextMeshProUGUI scoreText;

    [Header("Score" + "Settings")]
    public int currentScore;
    
    [Header("TimerText" +"Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;

    [Header("Timer" + "Format Settings")]
    public bool hasFormat;
    public TimerFormats format;
    private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();

    [Header("UI")]
    public Canvas pauseMenu;


    private void Start()
    {
        gameOverScreenGameObject.SetActive(true);

        timeFormats.Add(TimerFormats.Whole, "0");
        timeFormats.Add(TimerFormats.TenthDecimal, "0.0");
        timeFormats.Add(TimerFormats.HundrethsDecimal, "0.00");
    }
    private void Update()
    {
        Timer();
    }

    void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }

    public void ScoreText()
    {
        currentScore = currentScore + 1;
        scoreText.text = currentScore.ToString();
    }
    
    public void Timer()
    {
        if (pauseMenu.enabled == false)
        {
            if (cow.activeInHierarchy != false)
            {
                currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
                timerText.text = hasFormat ? currentTime.ToString(timeFormats[format]) : currentTime.ToString();
            }
            if (cow.activeInHierarchy != true)
            {
                timerText.text = currentTime.ToString(timeFormats[format]);
            }
        }
    }

     
}

public enum TimerFormats
{
    Whole,
    TenthDecimal,
    HundrethsDecimal
}
