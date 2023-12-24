using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour
{

    public int spawnItems = 5;

    public GameObject items;
    public GameObject player;

    void Start()
    {
        StartSpawn(spawnItems, 0f);
    }

    public void StartSpawn(int spawnItems, float cooldown)
    {
        StartCoroutine(SpawnItemCooldown(spawnItems, cooldown));
    }

    IEnumerator SpawnItemCooldown(int spawnItems, float cooldown)
    {
        yield return new WaitForSeconds(cooldown);
        ItemSpawn(spawnItems);

    }

    private void ItemSpawn(int spawnItems)
    {
        for (int i = 0; i < spawnItems; i++)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 0);

            while (Vector3.Distance(randomPosition, player.transform.position) < 1f)
            {
                randomPosition = new Vector3(Random.Range(-7, 7), Random.Range(-4, 4), 0);
            }


            GameObject newitem = Instantiate(items, randomPosition, Quaternion.identity);
            newitem.GetComponent<Collider2D>().enabled = true;

        }
    }
    

}
