using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish1 : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }
}
