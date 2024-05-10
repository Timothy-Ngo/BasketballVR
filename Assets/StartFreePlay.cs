using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFreePlay : MonoBehaviour
{

    public GameObject panel;
    public void Start()
    {
        panel.SetActive(true);
    }
    public void StartGame()
    {
        panel.SetActive(false);
    }
}
