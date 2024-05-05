using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void FreePlay()
    {
        SceneManager.LoadScene("Free Play");
    }

    public void TimedPlay()
    {
        SceneManager.LoadScene("Timed Play");
    }
    
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
    }

}
