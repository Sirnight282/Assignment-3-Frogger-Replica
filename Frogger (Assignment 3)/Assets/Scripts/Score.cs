using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;
    public Text scoreText;
    public static int Lives = SelectLives.Lives;
    public Text livesText;
    public Text PlayerName;
    public static int DeathCounter = 0;
   
    
    private void Start()
    {
        
        scoreText.text = CurrentScore.ToString() + " Points";
        livesText.text = "Lives: " + Lives.ToString();
        PlayerName.text = "Now Playing: " + GetPlayerName.Name;    
    }
}
