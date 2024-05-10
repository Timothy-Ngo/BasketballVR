using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer1 : MonoBehaviour
{
    public float totalTime = 60.0f; // Total time for the timer
    private float currentTime; // Current time left on the timer
    public TextMeshProUGUI timerText; // Reference to the UI text to display the timer

    public GameObject results;
    public TextMeshProUGUI resultsText;
    public bool activeTimer = false;
    public BasketballScore score;
    void Start()
    {
        results.SetActive(false);
        currentTime = totalTime; // Set current time to total time initially
    }

    void Update()
    {
        if (activeTimer)
        {
            // Update the timer only if it's greater than zero
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime; // Decrease the current time by the time passed since the last frame
                UpdateTimerDisplay(); // Update the timer display
            }
            else
            {
                // Timer has reached zero, you can add code here to handle what happens when the timer finishes
                //Debug.Log("Timer Finished!");
                currentTime = 0;
                UpdateTimerDisplay();
                results.SetActive(true);
                resultsText.text = $"You have scored {score.count} shot(s) in one minute";   
            }
        }
    }

    void UpdateTimerDisplay()
    {
        // Convert the current time to minutes and seconds
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        // Update the UI text to display the current time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer()
    {
        activeTimer = true;
    }

    public void StopTimer()
    {
        activeTimer = false;
    }

    public void ResetTimer()
    {
        currentTime = totalTime;
    }

}

