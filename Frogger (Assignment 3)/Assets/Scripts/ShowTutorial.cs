using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ShowTutorial : MonoBehaviour
{
    public GameObject Panel;
    // Update is called once per frame
    void Update()
    {
       if (Menu.Tutorial == true)
        {
            Panel.SetActive(true);
        }
        else
        {
            Panel.SetActive(false);
        }
    }
}
