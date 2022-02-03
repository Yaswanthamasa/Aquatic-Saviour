using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] enemyReference;
    private GameObject spawnedEnemy;
    //private GameObject spawnedFish;
    
    [SerializeField]
    private Transform anchorPos, minePos, plantPos, top2Pos, top3Pos, top4Pos, top5Pos;

    private int randomIndex;
    private int randomSide; 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame

    IEnumerator SpawnEnemies(){

        while(true){
            yield return new WaitForSeconds(Random.Range(2,4));
            randomIndex = Random.Range(0,enemyReference.Length);
            randomSide = Random.Range(0,2);
            //spawnedEnemy = Instantiate(enemyReference[randomIndex]);
            spawnedEnemy = Instantiate(enemyReference[randomIndex]);
            

            if(randomIndex==0){
                spawnedEnemy.transform.position = anchorPos.position;
                spawnedEnemy.GetComponent<Anchor>().speed = -2f;
                //spawnedFish.transform.position = minePos.position;
                //spawnedFish.GetComponent<Fish1>().speed = -2f;
            }
            
            else if(randomIndex==1){
                spawnedEnemy.transform.position = minePos.position;
                spawnedEnemy.GetComponent<Mine>().speed = -2f;
                //spawnedFish.transform.position = anchorPos.position;
                //spawnedFish.GetComponent<Fish1>().speed = -2f;
            }
            else{
                
                spawnedEnemy.transform.position = top4Pos.position;
                spawnedEnemy.GetComponent<Fish>().speed = -2f;
            }
        }
    }
}