using UnityEngine;

public class HoverLight : MonoBehaviour
{
    private Light lightComponent;

    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    void OnMouseEnter()
    {
        // Turn off the light when the mouse hovers over it
        lightComponent.enabled = false;
    }

    void OnMouseExit()
    {
        // Turn on the light when the mouse exits
        lightComponent.enabled = true;
    }
}
