using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private string ANCHOR = "Anchor";
    private string MINE = "Mine";
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag(ANCHOR))
        {
            Destroy(collision.gameObject);
        }
        if(collision.CompareTag(MINE))
        {
            Destroy(collision.gameObject);
        }
    }
}
