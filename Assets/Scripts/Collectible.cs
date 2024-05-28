using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Collect();
        }
    }

    void Collect()
    {
        // Code to handle collection, e.g., increase score, play sound, etc.
        Destroy(gameObject);
    }
}
