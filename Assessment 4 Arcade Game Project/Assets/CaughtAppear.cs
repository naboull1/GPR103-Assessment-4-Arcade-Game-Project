using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CaughtAppear : MonoBehaviour
{
    [SerializeField] public Image endGameImage;


    // Start is called before the first frame update
    void Start()
    {
        //print("caughtscreenworking");
        // endGameImage.transform.position.Set(0.05f, 0.05f, 0f);
    }

    void onTriggerEnter(Collider other)

    {
        print("caughtscreenworking2");

        if (other.CompareTag("caughtscreen"))
        {
            endGameImage.visible = true;
            print("caughtscreenworking3");
        }

    }
}
