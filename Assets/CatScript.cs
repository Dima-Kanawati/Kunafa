using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true; //To stop the game when game over.

    // Start is called before the first frame update
    void Start()
    {
        //To trigger the "Game over" when the cat crashes into a pipe.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if(transform.position.y > 15 || transform.position.y < -15)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
    //We added this method because pipes are not triggers (We need collisions).
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
