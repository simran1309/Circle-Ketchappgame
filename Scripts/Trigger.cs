using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public EdgeCollider2D ColGoal;
    public BoxCollider2D ColRing,ColRing2;
    public CircleCollider2D ColPlayer;
    public bool istriggered = false;
    public GameObject Player;
    public GameManager gameManager;
    public int pointValueUp;
    public int pointValueDown;
    public SpawnSpikes spikes;
    public Animator anim;
    public PlayerDeath death;
    public Player playerscript;
    public float speed;
    Rigidbody2D Playerrb;
    public GameObject Ringup;
    public GameObject Ringdown;
    public ParticleSystem burst;
    Rigidbody2D rigidbody;
   // public CameraController cam;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        ColGoal.enabled = true;
        ColRing.enabled = true;
        ColRing2.enabled = true;
        Playerrb = Player.GetComponent<Rigidbody2D>();
        Ringup.GetComponent<SpriteRenderer>().enabled = true;
        Ringdown.GetComponent<SpriteRenderer>().enabled = true;
        playerscript.enabled = true;
        
        istriggered = false;
    }

    // Update is called once per frame
    void Update()
    {

        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.transform.position = new Vector2(transform.position.x, Random.Range(-1, 3));
        if (death.isDead)
        {
            anim.Play("ring");
            spikes.Playit();
            ColGoal.enabled = false;
        }

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        
       // cam.enabled = false;
        if (col.gameObject.tag == "Player")
          {
            ColRing.enabled = false;
            Debug.Log("Goal");

                spikes.Playit();

            ColRing.enabled = false;
            ColRing2.enabled = false;
            CheckScore();

           // ColGoal.enabled = false;  
            }
           
        }


   
    void OnCollisionEnter2D(Collision2D col)
    {
      
        if (col.collider == ColPlayer)
        {
            Jump();

            Debug.Log("oops");
            playerscript.enabled = false;
          
        }
       
    }    void OnTriggerExit2D(Collider2D col)
    {
        istriggered = false;
       // ColGoal.enabled = true;
       
    }
    void Jump()
    { 
       
        { Playerrb.AddForce(transform.position * speed); }
      

     }
    void Disappear()
    {
        burst.Emit(10);
        Ringup.GetComponent<SpriteRenderer>().enabled = false;
        Ringdown.GetComponent<SpriteRenderer>().enabled = false;

    }
    void CheckScore()
    {
    if (istriggered == false)
    {
        if (ColPlayer.transform.position.y < ColGoal.transform.position.y)
        { 
            gameManager.UpdateScore(pointValueDown);
            Invoke("Disappear", 0.7f);
                istriggered = true;
            }
        if (ColPlayer.transform.position.y > ColGoal.transform.position.y)
        {
            gameManager.UpdateScore(pointValueUp);
            Invoke("Disappear", 0.7f);
                istriggered = true;
            }
    }
    istriggered = true;
   }
    void camTriggerOn()
    {
      //  cam.enabled = true;
    }
 }                              
               



        
