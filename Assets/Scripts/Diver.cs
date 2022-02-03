using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diver : MonoBehaviour
{

    public Text GarbageCounter;
    private int waste1 = 0;


    public float moveForce = 10f;
    public float jumpForce = 11f;

    private float movement;
    private Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;
    private string SWIM_ANIMATION = "Swim";
    private string ANCHOR = "Anchor";
    private string MINE = "Mine";

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //garbageCounter = GameObject.Find("GarbageCounter");
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(ANCHOR))
        {
            //isGrounded  = true;
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag(MINE))
        {
            //isGrounded  = true;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Tin1")){
            Collect(other.GetComponent<Garbage>());
        }
    } 

    private void Collect(Garbage collectible){
        if(collectible.Collect()){
                waste1++;
                UpdateGUI();
        }
    }

    private void UpdateGUI(){
        //GarbageCounter.text = waste1.ToString();
        GarbageCounter.GetComponent<UnityEngine.UI.Text>().text = waste1.ToString();
    }
}
