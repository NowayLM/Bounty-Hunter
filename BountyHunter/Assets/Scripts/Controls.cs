using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").transform.position = new Vector3(-8.5f, .7f, -8.5f);
    }

    // Update is called once per frame
    float x = new float();
    float y = new float();
    float z = new float();
    void Update()
    {
        x = GameObject.Find("Player").transform.position.x;
        y = GameObject.Find("Player").transform.position.y;
        z = GameObject.Find("Player").transform.position.z;
        float deltaX = Input.GetAxis("Vertical") / 10;
        if (deltaX > 0.02)
        {
            deltaX = 0.02f;
        }
        if (deltaX < -0.02)
        {
            deltaX = -0.02f;
        }
        float deltaZ = Input.GetAxis("Horizontal") / 10;
        if (deltaZ > 0.02)
        {
            deltaZ = 0.02f;
        }
        if (deltaZ < -0.02)
        {
            deltaZ = -0.02f;
        }
        if(deltaX != 0 && deltaZ != 0)
        {
            deltaX /= 2;
            deltaZ /= 2;
        }
        GameObject.Find("Player").transform.position += new Vector3 (deltaX, 0, 0 - deltaZ);
        //Quaternion target = Quaternion.Euler(0, deltaX, 0);
        GameObject.Find("Player").transform.rotation = Quaternion.Euler(-90, Mathf.Rad2Deg * (Mathf.Atan2(deltaZ, deltaX)), 0);
    }
}
