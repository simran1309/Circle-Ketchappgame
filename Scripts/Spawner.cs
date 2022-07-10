using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
   // public GameObject obstaclePrefab2;
    //public GameObject obstaclePrefab3;
   
  
    

    // private Vector3 spawnPos2 = new Vector3(40, 0, 0);
    //private Vector3 spawnPos3 = new Vector3(20, 0, 0);
    private float startDelay = 5;     
    private float repeatRate = 40;

   // private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        //obstaclePrefab = GameObject.Find("Obstacle");
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
       // anim = obstaclePrefab2.GetComponent<Animator>();

        // playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
       

    }

    void SpawnObstacle()
    {
          Vector3 spawnPos = new Vector3(10, 0, 0);
       // Vector3 spawnPos2 = new Vector3(30, 0, 0);
        // if (playerControllerScript.gameOver == false)
        //{
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
     //  Instantiate(obstaclePrefab2, spawnPos2, obstaclePrefab2.transform.rotation);
        //Instantiate(obstaclePrefab3, spawnPos3, obstaclePrefab3.transform.rotation);

      Destroy(obstaclePrefab,20);
     // Destroy(obstaclePrefab2, 20);

        // }
    }
    
    }

