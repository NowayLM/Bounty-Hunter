﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class MapGen : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Ground;
    public Transform Wall;
    public Transform Bush;
    public Transform Water;
    public Transform Heal;
    [Range(-5f, 5f)]
    public float decalage;

    [Range(0,1)]
    public float outlinePercent;

    public void GenMap()
    {
        char[][] arr = ReadMap("1");
        for (int x = 0; x < arr.Length; x++)
        {
            for (int y = 0; y < arr[x].Length; y++)
            {
                Vector3 tilePosition = new Vector3(-arr.Length / 2 + 0.5f + x, 0, -arr[x].Length + 0.5f + y);
                if (arr[x][y] == '.') 
                {
                    Transform newTile = Instantiate(Ground, tilePosition - Vector3.up * .5f, Quaternion.Euler(Vector3.right * 90)) as Transform;
                    newTile.localScale = Vector3.one * (1 - outlinePercent);
                }
                else
                {
                    if (arr[x][y] == '2')
                    {
                        Transform newTile = Instantiate(Wall, tilePosition + Vector3.up * .04f + Vector3.right * 1.7f + Vector3.forward * decalage, Quaternion.Euler(Vector3.right * 0)) as Transform;
                        newTile.localScale = Vector3.one * (1 - outlinePercent) * 0.46f;
                    }
                    else
                    {
                        if (arr[x][y] == '3')
                        {
                            Transform newTile = Instantiate(Bush, tilePosition + Vector3.up * .25f, Quaternion.Euler(Vector3.right * 0)) as Transform;
                            newTile.localScale = Vector3.one * (1 - outlinePercent) * 0.5f;
                            Transform test = Instantiate(Ground, tilePosition - Vector3.up * .5f, Quaternion.Euler(Vector3.right * 90)) as Transform;
                            test.localScale = Vector3.one * (1 - outlinePercent);
                        }
                        else
                        {
                            if (arr[x][y] == '4')
                            {
                                Transform newTile = Instantiate(Water, tilePosition - Vector3.up * .5f, Quaternion.Euler(Vector3.right * 90)) as Transform;
                                newTile.localScale = Vector3.one * (1 - outlinePercent);
                            }
                            else
                            {
                                if (arr[x][y] == '5')
                                {
                                    Transform newTile = Instantiate(Heal, tilePosition, Quaternion.Euler(Vector3.right * 90)) as Transform;
                                    newTile.localScale = Vector3.one * (1 - outlinePercent);
                                }
                            }
                        }
                    }
                }
                
            }

        }
    }

    /**
     * readMap
     * 
     * Read a map text file and convert into a char[][]
     * 
     * Expected syntax for map files:
     * 
     * ......
     * ..22..
     * .2.2.2
     * ......
     * ..22..
     * .2.2.2
     * 
     * etc.
     *
     */
    public static char[][] ReadMap(string mapName)
    {
        // Get the map asset
        TextAsset mapAsset = Resources.Load<TextAsset>("Maps/" + mapName);

        // Read the lines of the specified map
        string[] mapLines = mapAsset.text.Split('\n');

        // List to hold the lines of char[]
        List<char[]> mapList = new List<char[]>();

        // Parse each line
        foreach (string mapLine in mapLines)
        {
            // Trim commas (they are optional)
            // Convert strings to char[] and add to the list
            mapList.Add(mapLine.Trim(new char[] { ',' }).ToCharArray());
        }

        // Convert to char[][] (array of arrays) a  nd return
        return mapList.ToArray();

}


void Start()
    {
        GenMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
