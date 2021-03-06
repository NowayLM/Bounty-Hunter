﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject model1;
    public GameObject model2;
    private GameObject currentModel; 
    void Start()
    {
        //model1.SetActive(false);
        //model2.SetActive(false);
        GameObject.Find("Player").transform.position = new Vector3(-8.5f, .7f, -8.5f);
        //if (PlayerPrefs.GetInt("CharacterSelected") == 0)
        //{
            //model1.SetActive(true);
            //currentModel = Instantiate(model1, GameObject.Find("Player").transform.position, GameObject.Find("Player").transform.rotation) as GameObject;
            //currentModel.transform.parent = transform;
        //}
        //else if(PlayerPrefs.GetInt("CharacterSelected") == 1)
        //{
           // model2.SetActive(true);
            //currentModel = Instantiate(model2, GameObject.Find("Player").transform.position, Quaternion.Euler(10, 0, 269.5f)) as GameObject;
            //currentModel.transform.parent = transform;
        //}
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
        float deltaX = Input.GetAxis("Vertical") * 5;
        if (deltaX > 2)
        {
            deltaX = 2;
        }
        if (deltaX < -2)
        {
            deltaX = -2;
        }
        float deltaZ = Input.GetAxis("Horizontal") * 5;
        if (deltaZ > 2)
        {
            deltaZ = 2;
        }
        if (deltaZ < -2)
        {
            deltaZ = -2;
        }
        if(deltaX != 0 && deltaZ != 0)
        {
            deltaX /= 2;
            deltaZ /= 2;
        }
        GameObject.Find("Player").transform.position += new Vector3 (deltaX * Time.deltaTime, 0, 0 - deltaZ * Time.deltaTime);
        GameObject.Find("Player").transform.rotation = Quaternion.Euler(-90, Mathf.Rad2Deg * (Mathf.Atan2(deltaZ * Time.deltaTime, deltaX * Time.deltaTime)), 0);
    }
}
