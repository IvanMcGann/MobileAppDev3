using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int enemyLimit = 20;
    private int currentEnemyCount = 0;

    public GameObject enemyPrefab;

    public Rect SpawnArea;
    // Update is called once per frame
    void Update()
    {
        // Avoid spawning too many enemies 
        if (currentEnemyCount < enemyLimit)
        {
            // no, no we do not! so create one.
            Vector3 spawnLocation = new Vector3(
                Random.Range(SpawnArea.x, SpawnArea.y),         // x position
                Random.Range(SpawnArea.width, SpawnArea.height),// y position
                0);                                             // z position 

            GameObject go = Instantiate(enemyPrefab, spawnLocation, Quaternion.identity);
            currentEnemyCount += 1; // we made one, so note it down in our count 
        }
    }

    // remove destroyed enemy
    public void enemyDied()
    {
        currentEnemyCount--;
    }
}