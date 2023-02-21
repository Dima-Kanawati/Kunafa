using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe; 
    public float spawnRate = 2; //How many seconds it should be between spawns.
    private float timer = 0; //Number that counts up. 
    public float heightOffset = 10; //To make the pipes spwan at random heights. 
    //Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            //Count up by one.
            timer = timer + Time.deltaTime; //Number that counts up every frame.
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        //To stay in the correct range.
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    } 
}
