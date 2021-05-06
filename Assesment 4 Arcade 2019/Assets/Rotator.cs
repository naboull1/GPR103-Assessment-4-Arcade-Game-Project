using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float x = 0.00f;
    public float y = 0.00f;
    public float z = 0.00f;

    // Start is called before the first frame update
    void Start()
    {
        //x = 0.00f;  //velocity
        //y = 0.00f;  //velocity
        //z = 0.00f;  //velocity
    }

    // Update is called once per frame
    void Update()
    {

            transform.Rotate(new Vector3(x, y, z)); //applying rotation

    }
}
