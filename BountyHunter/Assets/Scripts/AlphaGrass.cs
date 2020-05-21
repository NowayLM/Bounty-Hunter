using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AlphaGrass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*double distance = Math.Sqrt(
            (GameObject.Find("Player").transform.position.x - transform.position.x) * (GameObject.Find("Player").transform.position.x - transform.position.x) +
            (GameObject.Find("Player").transform.position.z - transform.position.z) * (GameObject.Find("Player").transform.position.z - transform.position.z)
        );
        //print (distance);
        if (distance < 2)
        {
            Color tmp = GetComponent<MeshRenderer>().material.color;
            if (tmp.a > 0.2f)
            {
                tmp.a -= 0.8f;
            }
            print(tmp.a);

        }
        else
        {
            Color tmp = GetComponent<MeshRenderer>().material.color;
            if (tmp.a < 1)
            {
                tmp.a += 0.8f;
            }
            print(tmp.a);
        }*/
    }
}
