using UnityEngine;

public class ResetScript : MonoBehaviour
{
    private void Awake()
    {
        //reset everything
        Score.DeathCounter = 0;
        Score.Lives = 3;
        Score.CurrentScore = 0;
        CarScript.Multiplier = 1;
        Debug.Log("reset");
    }
}
