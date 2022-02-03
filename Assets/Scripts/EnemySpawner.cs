using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] enemyReference;
    /*
        Index - GameObject
        0 - anchor
        1 - mine
        2 - 4 gold fish
        3 - dead fish
        4 - blue fish
        5 - yellow fish
    */
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
            //randomIndex = 8;
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
            else if(randomIndex==3){
                spawnedEnemy.transform.position = plantPos.position;
                spawnedEnemy.GetComponent<Fish>().speed = -2f;
            }
            else if(randomIndex>5){
                spawnedEnemy.transform.position = anchorPos.position;
                spawnedEnemy.GetComponent<Garbage>().speed = -2f;
            }
            else{
                int randomTop = Random.Range(0,4);
                if(randomTop==0){
                    spawnedEnemy.transform.position = top2Pos.position;
                    spawnedEnemy.GetComponent<Fish>().speed = -2f;
                }
                else if(randomTop==1){
                    spawnedEnemy.transform.position = top3Pos.position;
                    spawnedEnemy.GetComponent<Fish>().speed = -2f;
                }
                else if(randomTop==2){
                    spawnedEnemy.transform.position = top4Pos.position;
                    spawnedEnemy.GetComponent<Fish>().speed = -2f;
                }
                else if(randomTop==3){
                    spawnedEnemy.transform.position = top5Pos.position;
                    spawnedEnemy.GetComponent<Fish>().speed = -2f;
                }
                
            }
        }
    }
}