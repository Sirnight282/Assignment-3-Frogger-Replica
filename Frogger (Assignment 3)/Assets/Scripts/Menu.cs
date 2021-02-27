using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static bool Tutorial = false;
    public void StartGame()
    {
        Debug.Log(GetPlayerName.Name);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ToggleTutorial()
    {
        Tutorial = !Tutorial;
        Debug.Log("Bool: " + Tutorial);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game has been quit");
    }
}
