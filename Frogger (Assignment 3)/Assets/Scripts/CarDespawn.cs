using UnityEngine;

public class CarDespawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Destroy(col.gameObject);
        }
    }
}
