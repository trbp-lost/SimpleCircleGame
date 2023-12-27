using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.name != sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void OpenURL()
    {
        Application.OpenURL("https://www.linkedin.com/in/tengku-revino-buana-putra/");
    }
}
