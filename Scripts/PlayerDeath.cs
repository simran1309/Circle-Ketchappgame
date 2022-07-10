using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDeath : MonoBehaviour
{
    
  //  public GameManager gameManager;
    public bool isDead = false;
  
   // public MeshCollider ColRing;
    public BoxCollider2D ColTop, ColBottom,  ColRing;
    public ParticleSystem burst;
  

    // Start is called before the first frame update
    void Start()
    {
       
        //anim = Spikes.GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        burst.transform.position = this.transform.position;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
       
       
        if (col.collider == ColTop)
        {
            Debug.Log("Death");
            isDead = true;

        }
        if (col.collider == ColBottom)
        {
            Debug.Log("Death");
            isDead = true;
        } 
       
     

    }
    void OnBecameInvisible()
    {
        isDead = true;
    }
  
}
