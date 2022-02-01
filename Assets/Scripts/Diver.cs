using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diver : MonoBehaviour
{
    public float moveForce = 10f;
    public float jumpForce = 11f;

    private float movement;
    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string SWIM_ANIMATION = "Swim";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       PlayerMoveKeyboard(); 
       AnimatePlayer();
    }

    void PlayerMoveKeyboard()
    {
        movement = Input.GetAxis("Vertical");
        //movement = (float)Input.GetButton("Jump");
        transform.position += new Vector3(0f,movement,0f)*Time.deltaTime*moveForce;

    }

    void AnimatePlayer()
    {
        anim.SetBool(SWIM_ANIMATION,true);
    }
}
