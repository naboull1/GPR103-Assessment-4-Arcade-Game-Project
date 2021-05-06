using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaughtAppear : MonoBehaviour
{
    [SerializeField] private Image endGameImage;


    // Start is called before the first frame update
    void Start()
    {
        //print("caughtscreenworking");
        // endGameImage.transform.position.Set(0.05f, 0.05f, 0f);
    }

    //void onTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("caughtscreen"))
    //    {
    //        endGameImage.enabled = true;
    //        print("caughtscreenworking");
    //    }

    //}


    //void onTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("caughtscreen"))
    //    {
    //        endGameImage.enabled = false;
    //        print("caughtscreenworking");
    //    }

    //}

}
