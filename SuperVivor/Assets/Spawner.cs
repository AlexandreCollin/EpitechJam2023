using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;
    public GameObject target;

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E)) {
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            GameObject newGameObject = Instantiate(enemyPrefabs[randEnemy], spawnPoints[randSpawnPoint].position, transform.rotation);

            newGameObject.GetComponent<FollowCharacter>().target = target;
        }
    }
}
