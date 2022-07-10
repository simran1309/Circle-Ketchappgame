using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour

{
    public CircleCollider2D ColPlayer;
    public PlayerDeath player;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.collider == ColPlayer)
        {
            player.isDead = true;
            Debug.Log("Dead");
            
        }
    }
}
