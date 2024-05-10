using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimePlay : MonoBehaviour
{
    public Timer1 timer;
    public GameObject panel;
    public void Start()
    {
        panel.SetActive(true);
        timer.StopTimer();
    }
    public void StartGame()
    {
        timer.ResetTimer();
        timer.StartTimer();
        panel.SetActive(false);
    }


}
