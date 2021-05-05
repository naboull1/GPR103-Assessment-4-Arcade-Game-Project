using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
//using System.Numerics;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class PlayerMovement :  MonoBehaviour
{
    // Start is called before the first frame update

    public bool playerIsAlive; //Is the player currently alive?
    public bool playerCanMove; //Can the player currently move?
    public float speed;
    private Vector2 targetPosition;
    private GameManager myGameManager; //A reference to the GameManager in the scene.
    GameData mGameData2;
    GameData myGameData;
    public string playerName = "";
    public GameObject scoreText;
    private int myScore;


    void Start()
    {

        targetPosition = new Vector2(0.0f, 0.0f);
        mGameData2 = new GameData();
        myGameData = new GameData(mGameData2);
        myScore = 0;
        scoreText = GameObject.Find("ScoreText");
        myGameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }



    private bool calculateFinalScore()
    {
        //calculate all the given variables for scoring
        return false;
    }






    // Update is called once per frame
    void Update()
    {
        if (playerCanMove && playerIsAlive)
        {
            if (Input.GetMouseButtonDown(0))
            {
                targetPosition = Input.mousePosition;
                targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(targetPosition.x, targetPosition.y, 0.0f));
            }
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPosition, speed * Time.deltaTime);

        }

    }






    private void OnTriggerEnter2D(Collider2D collision)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);

        print("yes");
        print("yes");

        if (playerIsAlive)
        {
            if (collision.transform.GetComponent<kitchenCatcherScript>())
            {
                //myScore = "Score: "+ 10;

                print("caught");
                playerIsAlive = true;
                playerCanMove = true;
                //myGameData.lives -= 1;
                //myGameData.SaveData(myGameData);
            }


            else if (collision.transform.parent.GetComponent<Snacks>())
            {
                ++myScore;

                print("picked up snack");
                print("Score" );
                print(myScore);
                playerIsAlive = true;
                playerCanMove = true;
                //myGameData.lives -= 1;
                //myGameData.SaveData(myGameData);
                //destroy
            }


        }
    }




}

