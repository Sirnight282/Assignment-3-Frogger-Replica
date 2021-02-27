using UnityEngine;
using UnityEngine.UI;

public class SelectLives : MonoBehaviour
{
    public Dropdown PickLives;
    public static int Lives;

    public void Start()
    {
        Lives = 3;
    }
    public void ChangeLives()
    {
        
        switch (PickLives.value)
        {
            case 1:
                Debug.Log("1 Life Selected");
                Lives = 1;
                Score.Lives = 1;

                break;
            case 2:
                Debug.Log("2 Lives Selected");
                Lives = 2;
                Score.Lives = 2;
                break;
            case 3:
                Debug.Log("3 Lives Selected");
                Lives = 3;
                Score.Lives = 3;
                break;
            default:
                Debug.Log("Please select amount of lives");
                Lives = 3;
                Score.Lives = 3;
                break;
        }
    }

}