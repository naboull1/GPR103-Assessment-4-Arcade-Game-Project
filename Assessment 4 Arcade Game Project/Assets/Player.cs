using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
//using System.Numerics;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameData mGameData2;

    GameData myGameData;

    public string playerName = "";
    public bool flagTest;
    public GameObject scoreText;
    
    public int playerTotalLives; //Players total possible lives.
    public int playerLivesRemaining; //PLayers actual lives remaining.

    public bool playerIsAlive; //Is the player currently alive?
    public bool playerCanMove; //Can the player currently move?
    public GameObject bullet;

    private string myScore;
    private GameManager myGameManager; //A reference to the GameManager in the scene.
    // Start is called before the first frame update
    private void Awake()
    {
        playerIsAlive = true; //Is the player currently alive?
        playerCanMove = true; //Can the player currently move   
    }
    void Start()
    {
    
    mGameData2 = new GameData();
    myGameData = new GameData(mGameData2);
        //myScore = "Score: ";
        //scoreText = GameObject.Find("ScoreText");
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
        if(playerCanMove && playerIsAlive)
        {
            myGameData.lives -= 1;
            myGameData.SaveData(myGameData);
            Debug.DrawRay(transform.position, Vector2.up, new Color(100.0f, 0.0f, 0.0f));
            Debug.DrawRay(transform.position, Vector2.left, new Color(0.0f, 100.0f, 0.0f));
            Debug.DrawRay(transform.position, Vector2.right, new Color(0.0f, 100.0f, 100.0f));
            Debug.DrawRay(transform.position, Vector2.down, new Color(0.0f, .0f, 100.0f));

            if (Input.GetKeyUp(KeyCode.UpArrow) && transform.position.y < myGameManager.levelConstraintTop)
            {
                transform.Translate(new Vector2(0, 1.25f));
            }
            else if (Input.GetKeyUp(KeyCode.DownArrow) && transform.position.y > myGameManager.levelConstraintBottom)
            {
                transform.Translate(new Vector2(0, -1.25f));
            }
            else if (Input.GetKeyUp(KeyCode.LeftArrow) && transform.position.x > myGameManager.levelConstraintLeft)
            {
                transform.Translate(new Vector2(-1.25f, 0));
            }
            else if (Input.GetKeyUp(KeyCode.RightArrow) && transform.position.x < myGameManager.levelConstraintRight)
            {
                transform.Translate(new Vector2(1.25f, 0));
            }
            else if(Input.GetKeyUp(KeyCode.Space))
            {
                GameObject vBullet = Instantiate(bullet, transform.position, transform.rotation);
               
                vBullet.GetComponent<Rigidbody2D>().AddForce(transform.forward * 10);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);

             

        if (playerIsAlive)
        {
            if (collision.transform.parent.GetComponent<Vehicle>() != null)
            {
                //myScore = "Score: "+ 10;

                print("yes");
                playerIsAlive = false;
                playerCanMove = false;
                myGameData.lives -= 1;
                myGameData.SaveData(myGameData);
            }
        }

        

    } 

    
}
