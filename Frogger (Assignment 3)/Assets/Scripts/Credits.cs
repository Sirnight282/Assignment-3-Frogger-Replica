using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Text EndScore;
    public Text LivesUsed;
    public void Start()
    {
        EndScore.text = "Ending Score: " + Score.CurrentScore;
        LivesUsed.text = "Lives Lost: " + Score.DeathCounter;
    }
    public void BackToMenu()
    {
        //reset everything
        Score.DeathCounter = 0;
        SelectLives.Lives = 3;
        //Score.Lives = 3;
        Score.CurrentScore = 0;
        CarScript.Multiplier = 1;
        
        SceneManager.LoadScene(0);
        
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game has been quit");
    }
}
