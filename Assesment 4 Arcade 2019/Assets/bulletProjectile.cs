using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletProjectile : MonoBehaviour
{

    public const float TTL = 5;
    private float timeCount;
    public bool flagTest;
    // Start is called before the first frame update
    void Start()
    {
        timeCount = TTL;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount -= Time.deltaTime * 1.0f;
        if (timeCount <= 0)
            Destroy(this.gameObject);
    }
}
