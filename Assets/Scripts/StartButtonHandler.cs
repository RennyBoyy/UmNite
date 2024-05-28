using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButtonHandler : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject gamePanel;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        startPanel.SetActive(false);
        gamePanel.SetActive(true);
    }
}
