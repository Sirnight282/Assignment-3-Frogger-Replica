using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject Frog;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);

        //stop player going out of bounds by pushing them back
        if (Frog.transform.position.y < -4)
            rb.MovePosition(rb.position + Vector2.up);
        else if (Frog.transform.position.y > 4)
            rb.MovePosition(rb.position + Vector2.down);
        else if (Frog.transform.position.x < -6)
            rb.MovePosition(rb.position + Vector2.right);
        else if (Frog.transform.position.x > 6)
            rb.MovePosition(rb.position + Vector2.left);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Score.Lives--;
            Score.DeathCounter++;
            if (Score.Lives < 1)
            {
                Debug.Log("We Lost");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
