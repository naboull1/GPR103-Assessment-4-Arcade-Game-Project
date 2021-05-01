using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
//using System.Numerics;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public class PlayerMovement :  Monobehaviour
{
    // Start is called before the first frame update

    public float speed;
    private Vector2 targetPosition;
    void Start()
    {

        targetPosition = new Vector2(0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
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

    

    if (playerIsAlive)
    {
        if (collision.transform.parent.GetComponent<Vehicle>() != null)
        {
            //myScore = "Score: "+ 10;

            print("yes");
            playerIsAlive = true;
            playerCanMove = true;
            myGameData.lives -= 1;
            myGameData.SaveData(myGameData);
        }
    }