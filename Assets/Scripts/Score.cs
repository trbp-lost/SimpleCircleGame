using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private int score = 0;

    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name == "no1" 
            || currentScene.name == "no2"
            || currentScene.name == "no3"
            || currentScene.name == "no4"
            || currentScene.name == "no5"
            || currentScene.name == "no6")
        {
            gameObject.SetActive(false);
        }

        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = "Score : 0";
    }

    public int AddScore(int addscore)
    {
        score += addscore;
        textMeshPro.text = "Score : " + score;

        return score;
    }
}
