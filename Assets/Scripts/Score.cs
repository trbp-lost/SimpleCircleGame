using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Score : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private int score = 0;

    void Start()
    {
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
