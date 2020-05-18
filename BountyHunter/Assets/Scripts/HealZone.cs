using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UnityEditor;

class HealZone : MonoBehaviour 
{
    float speed = 0.5f;
    void Update()
    {
        Console.WriteLine("TEst");

        //Script to rotate the heal, just need to acces the model

        //object healModel = Resources.Load("Assets/Models/Materials/heal_object.fbx");
        //Transform t = (Transform)healModel;
        //t.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
