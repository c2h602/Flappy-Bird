using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRiginbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRiginbody.velocity = Vector2.up * flapStrenght;
        }

        if (transform.position.y > 24 || transform.position.y < -24)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
