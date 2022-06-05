using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab, powerUpPrefab;
    private float bound = 9.0f;
    public int enemyCount, waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        Instantiate(powerUpPrefab, SpawnPos(), powerUpPrefab.transform.rotation);
    }

    void SpawnEnemyWave(int enemiesToSpawn){

        for(int i=0; i<enemiesToSpawn; i++){
            Instantiate(enemyPrefab, SpawnPos(), enemyPrefab.transform.rotation);
        }
        
    }

    Vector3 SpawnPos(){
        float spawnPosX = Random.Range(-bound, bound);
        float spawnPosZ = Random.Range(-bound, bound);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0){
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerUpPrefab, SpawnPos(), powerUpPrefab.transform.rotation);
        }
    }
}
