using UnityEngine;
using TMPro;
using System.Collections.Generic;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    [Header("GameObjects")]
    public GameObject cow;

    [Header("Final" + "Score" + "Component")]
    public TextMeshProUGUI finalScore;

    [Header("Final" + "Score" + "Settings")]
    public int finalScoreInt;

    [Header("Final" + "Time" + "Component")]
    public TextMeshProUGUI finalTime;

    [Header("Final" + "Time" + "Settings")]
    public float finalTimeFloat;

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



    public static GameManager gameManager { get; private set; }


    private void Start()
    {
        timeFormats.Add(TimerFormats.Whole, "0");
        timeFormats.Add(TimerFormats.TenthDecimal, "0.0");
        timeFormats.Add(TimerFormats.HundrethsDecimal, "0.00");
    }
    private void Update()
    {
        if(pauseMenu.enabled == true)
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
}

public enum TimerFormats
{
    Whole,
    TenthDecimal,
    HundrethsDecimal
}
