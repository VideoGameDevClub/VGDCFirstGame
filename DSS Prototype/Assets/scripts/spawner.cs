using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject zombie;
    public GameObject zombieBig;
    public int bigChance = 20;
    private float spawnCounter;

    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = Random.Range(spawnTime * 0.5f, spawnTime * 2f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            spawnCounter -= Time.deltaTime;

            if (spawnCounter <= 0)
            {
                //big spawn
                if(Random.Range(1, bigChance) == 5)
                 {
                     Instantiate(zombieBig, transform.position, Quaternion.identity);
                 }
                else
                {
                    Instantiate(zombie, transform.position, Quaternion.identity);
                    spawnCounter = Random.Range(spawnTime * 0.5f, spawnTime * 2f);
                }
                
            }
        
    }
}
