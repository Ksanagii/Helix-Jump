using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isGameStarted;
    public static bool gameOver;
    public static bool levelCompleted;
    public static bool mute = false;
    public static int currentLevelIndex;
    public static int numberOfPassedRings;
    public static int score = 0;
    public static int highScore = 0;

    void Awake()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0); // memoria interna
        currentLevelIndex = PlayerPrefs.GetInt("CurrentLevelIndex", 1);
        // nivel do jogo salvo na memoria interna
    }

    void Start()
    {
        Time.timeScale = 1; // desativa o pause do jogo
        gameOver = false;
        levelCompleted = false;
        isGameStarted = false;
        numberOfPassedRings = 0;
    }

    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0; // pausa o jogo
            if(Input.GetButton("Fire1"))
            {
                score = 0;
                SceneManager.LoadScene(0);
            }
        }
        if(levelCompleted)
        {
            Time.timeScale = 0; // pausa o jogo
            PlayerPrefs.SetInt("CurrentLevelIndex", currentLevelIndex + 1);
            if(Input.GetButton("Fire1"))
            {
                SceneManager.LoadScene(0);
            }
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            PlayerPrefs.SetInt("CurrentLevelindex", 1);
            SceneManager.LoadScene(0);
        }

    }
}
