using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 20f; // Total duration of the countdown timer
    private float timeRemaining; // Remaining time
    public TextMeshProUGUI countdownText; // Reference to the TextMeshPro text object

    void Start()
    {
        timeRemaining = totalTime;
        UpdateTimerDisplay();
        StartTimer();
    }

    void Update()
    {
        // Update the countdown timer
        timeRemaining -= Time.deltaTime;

        // Check if time has run out
        if (timeRemaining <= 0f)
        {
            timeRemaining = 0f;
            // Optionally handle what happens when the timer reaches zero
            Debug.Log("Timer has reached zero.");
            // Stop the timer or perform any other action
            // StopTimer();
        }

        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        // Convert remaining time to display format (e.g., mm:ss)
        string minutes = Mathf.Floor(timeRemaining / 60).ToString("00");
        string seconds = Mathf.Floor(timeRemaining % 60).ToString("00");
        // Update the TextMeshPro text object with the formatted time
        countdownText.text = minutes + ":" + seconds;
    }

    void StartTimer()
    {
        // Start the countdown timer
        InvokeRepeating("UpdateTimerDisplay", 0f, 1f); // Update the display every second
    }

    void StopTimer()
    {
        // Stop the countdown timer
        CancelInvoke("UpdateTimerDisplay");
    }
}
