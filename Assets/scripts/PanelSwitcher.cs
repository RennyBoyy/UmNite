using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject StartScreen; 
    public GameObject GameScene;    

    public void SwitchPanel()
    {
        StartScreen.SetActive(false);
        GameScene.SetActive(true);
    }
}
