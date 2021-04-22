using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    /// <summary>
    /// -1 = left, 1 = right
    /// </summary>
    public int moveDirection = 0;
    public float speed;
    public bool reverseOrder = true;
    public Vector2 startingPosition;
    public Vector2 endPosition;

    // Start is called before the first frame update
    void Start()
    {
        
        if (reverseOrder == true)
        {
            Vector2 temp = endPosition;
            endPosition = startingPosition;
            startingPosition = temp;

        }
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(reverseOrder)
        transform.Translate(Vector2.left * Time.deltaTime * speed * moveDirection);
        else
         transform.Translate(Vector2.right * Time.deltaTime * speed * moveDirection);

        ////when you multiply the inequality on both sides by -1 (or divide by -1), the inequality changes direction.
        //if ((transform.position.x * moveDirection) > (endPosition.x * moveDirection))
        //{
        //    transform.position = startingPosition;
        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
           //if (collision.transform.parent.GetComponent<BulletProjectile>() != null)
           // {
           //     print("Deleted");
           // //playerIsAlive = false;
           // //playerCanMove = false;
           // //GameObject.Destroy(this);
           // }
        


    }
}
