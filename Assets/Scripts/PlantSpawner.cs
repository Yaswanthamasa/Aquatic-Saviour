using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] plantReference;
    private GameObject spawnedPlant;
    private int randomIndex;

    [SerializeField]
    private Transform plantPos;
 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnPlants());
    }

    IEnumerator spawnPlants(){
        while(true){
            yield return new WaitForSeconds(3);
            randomIndex = Random.Range(0,plantReference.Length);
            spawnedPlant = Instantiate(plantReference[randomIndex]);
            spawnedPlant.transform.position = plantPos.position;
            spawnedPlant.GetComponent<Fish>().speed = -2f;
        }
    }

}