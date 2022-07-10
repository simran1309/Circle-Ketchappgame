using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnSpikes : MonoBehaviour
{
    public GameObject obstaclePrefab;
   
  
    private Animator anim;

    // Start is called before the first frame update
    void Awake()
    {
        anim = obstaclePrefab.GetComponent<Animator>();
        
    }
    void Start()
    {
        // InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        anim.Play("idle");

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObstacle()
    {
       // Vector3 spawnPos = new Vector3(30, 0, 0);
     // Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
       // Destroy(obstaclePrefab,20 );
    }
    
     public void Playit()
    {
        
        anim.Play("Spike");
    }  
   

}