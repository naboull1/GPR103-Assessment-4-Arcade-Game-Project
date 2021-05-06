using UnityEngine;
//using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class snackCount : MonoBehaviour
{
    // snack count
    public static int snacks;

     //text;

    private void Awake()
    {
        //reference the text
        //text = GetComponent<Text>();

        //Reset
        snacks = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //change the text on screen
       // text.text = "Snacks Eaten: " + snacks;
    }
}
