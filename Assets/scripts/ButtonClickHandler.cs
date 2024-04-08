using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public PanelSwitcher panelSwitcher; // Reference to the PanelSwitcher script

    void Start()
    {
        // Get the PanelSwitcher component from the Canvas
        panelSwitcher = GameObject.FindObjectOfType<PanelSwitcher>();
    }

    public void OnButtonClick()
    {
        // Call the SwitchPanel method in the PanelSwitcher script
        panelSwitcher.SwitchPanel();
    }
}

