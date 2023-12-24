using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FoodSpawn spawn = GameObject.Find("FoodSpawn").GetComponent<FoodSpawn>();
        Score score = GameObject.Find("Canvas/Panel/TextScore").GetComponent<Score>();

        if (spawn != null && collision.collider.tag == "Player")
        {
            Destroy(gameObject);
            score.AddScore(1);
            spawn.StartSpawn(1, 3);

            //Vector3 randomPosition = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
            //GameObject newitem = Instantiate(gameObject, randomPosition, Quaternion.identity);
            //newitem.GetComponent<Collider2D>().enabled = true;
            //newitem.name = "Food (Clone)";


        }
    }



}
