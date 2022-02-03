using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private string ANCHOR = "Anchor";
    private string MINE = "Mine";
    private string FOUR_FISH_TAG = "Fishes1";
    private string SINGLE_FISH_TAG = "Fish";
    private string AQUATIC_PLANTS_TAG = "AquaticPlants";
    private string GARBAGE_TAG = "Tin1";
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag(ANCHOR))
        {
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag(MINE))
        {
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag(FOUR_FISH_TAG)){
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag(SINGLE_FISH_TAG)){
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag(AQUATIC_PLANTS_TAG)){
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag(GARBAGE_TAG)){
            Destroy(collision.gameObject);
        }
    }
}
