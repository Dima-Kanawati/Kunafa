//This script calculate the player's score
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    //Refrence to the logic script.
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        //As soon as a new pipe spawns it will look through the hierarchu to find game object with "Logic" tag.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //To make that the cat is the one scoring.
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
    }
}
