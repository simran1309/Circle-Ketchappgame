using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    private float startDelay = 10;
    private float repeatRate = 15;
    public GameObject prefab;
    public RectTransform picture;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Clouds", startDelay, repeatRate);
    }
        // Update is called once per frame
        void Update()
    {
       
        //GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 20);
      picture = GetComponent<RectTransform>();
       
    
}
    void Clouds()
    {
        Vector3 spawnPos = new Vector3(-141, -105,-92);
        Instantiate(prefab, spawnPos, prefab.transform.rotation);
    }
}
