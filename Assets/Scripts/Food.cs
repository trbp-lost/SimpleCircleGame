using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Food : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        FoodSpawn spawn = GameObject.Find("FoodSpawn").GetComponent<FoodSpawn>();

        if (currentScene.name == "no8" || currentScene.name == "no7")
            Debug.Log(currentScene.name);
        else return;
        Score score = GameObject.Find("Canvas/Panel/TextScore").GetComponent<Score>();

        if (spawn != null && collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            score.AddScore(1);
            if (currentScene.name != "no8") return;
            spawn.StartSpawn(1, 3);

        }
    }

}
