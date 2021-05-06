using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class PanelAppear : MonoBehaviour
{
    public GameObject panel;
    int counter;
    public void showhidepanel()
    {

        {
            counter++;
            if (counter%2==1)
            {
                panel.gameObject.SetActive(false);
            }
            else
            {
                panel.gameObject.SetActive(true);
            }
        }
    }

}
