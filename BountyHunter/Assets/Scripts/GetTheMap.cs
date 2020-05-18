﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;
using System.IO;
using System;
using System.Xml.Serialization;

public class GetTheMap : MonoBehaviour
{
    // Start is called before the first frame update
    public static string map = GetMap();
    public static string GetMap()
    {
        string[] mapsList = System.IO.Directory.GetFiles("C:/Users/maxna/Documents/PROJET S2 UNITY/Bounty-Hunter/BountyHunter/Assets/Resources/Maps");
        List<string> mapsList2 = new List<string>();
        for (int i = 0; i < mapsList.Length; i++)
        {
            if (!mapsList[i].Contains(".meta"))
                mapsList2.Add(mapsList[i]);
        }
        int l = mapsList2.Count;
        int randIndex = new System.Random().Next(l);
        string choice = mapsList2[randIndex];
        string substr = choice.Substring(choice.Length - 5);
        return substr[0].ToString();
        }
}
