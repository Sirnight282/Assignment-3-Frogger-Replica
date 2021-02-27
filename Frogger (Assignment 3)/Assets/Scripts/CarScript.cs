using UnityEngine;
using UnityEngine.UI;

public class CarScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float Multiplier = SliderValueToText.sliderValueFloat;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;
    float speed = 1f;

    private void Start()
    {
        Multiplier = SliderValueToText.sliderValueFloat;
        speed = Random.Range(minSpeed, maxSpeed) * Multiplier;
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);

    }
}
