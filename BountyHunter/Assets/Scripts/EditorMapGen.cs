using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class EditorMapGen : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Ground;
    public Transform Wall;
    public Transform Bush;
    public Transform Water;
    public Transform Heal;
    public Transform Hitbox;
    public Transform WaterHitbox;
    [Range(-5f, 5f)]
    public float decalage;

    [Range(0, 1)]
    public float outlinePercent;

    private static Vector3 wall1 = new Vector3(0.9f, 0.63f, 1) * 24;

    public void EditorGenMap()
    {
        //string map = GetTheMap.newMap;
        string newMap = GetMapEditor();
        char[][] arr = ReadMap(newMap);
        for (int x = 0; x < arr.Length; x++)
        {
            for (int y = 0; y < arr[x].Length; y++)
            {
                Vector3 tilePosition = new Vector3(-arr.Length / 2 + 0.5f + x, 0, -arr[x].Length + 0.5f + y);
                if (arr[x][y] == '.' || arr[x][y] == '1')
                {
                    Transform newTile = Instantiate(Ground, tilePosition - Vector3.up * .2f, Quaternion.Euler(Vector3.right * 90)) as Transform;
                    newTile.localScale = Vector3.one * (1 - outlinePercent);
                }
                else
                {
                    if (arr[x][y] == '2')
                    {
                        Transform newTile = Instantiate(Wall, tilePosition + Vector3.up * .04f + Vector3.right * -0.28f + Vector3.forward * decalage, Quaternion.Euler(Vector3.right * -90)) as Transform;
                        newTile.localScale = wall1;
                        Transform newTile2 = Instantiate(Hitbox, tilePosition + Vector3.up, Quaternion.Euler(Vector3.right * -90)) as Transform;
                        newTile2.localScale = Vector3.one * (1 - outlinePercent);
                    }
                    else
                    {
                        if (arr[x][y] == '3')
                        {
                            Transform newTile = Instantiate(Bush, tilePosition + Vector3.up * .25f, Quaternion.Euler(Vector3.left * 90f)) as Transform;
                            newTile.localScale = Vector3.one * (1 - outlinePercent) * 25f;
                            Transform test = Instantiate(Ground, tilePosition - Vector3.up * .2f, Quaternion.Euler(Vector3.right * 90)) as Transform;
                            test.localScale = Vector3.one * (1 - outlinePercent);
                        }
                        else
                        {
                            if (arr[x][y] == '4')
                            {
                                Transform newTile = Instantiate(Water, tilePosition - Vector3.up * .5f, Quaternion.Euler(Vector3.right * 90)) as Transform;
                                newTile.localScale = Vector3.one * (1 - outlinePercent);
                                Transform newTile2 = Instantiate(WaterHitbox, tilePosition + Vector3.up, Quaternion.Euler(Vector3.right * -90)) as Transform;
                                newTile2.localScale = Vector3.one * (1 - outlinePercent);
                            }
                            else
                            {
                                if (arr[x][y] == '5')
                                {
                                    Transform newTile = Instantiate(Heal, tilePosition + Vector3.up, Quaternion.Euler(Vector3.right * 90)) as Transform;
                                    newTile.localScale = Vector3.one * (1 - outlinePercent) * 0.2f;
                                    Transform test = Instantiate(Ground, tilePosition - Vector3.up * .2f, Quaternion.Euler(Vector3.right * 90)) as Transform;
                                    test.localScale = Vector3.one * (1 - outlinePercent);
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
        Console.WriteLine("mapname");
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

            // Convert to char[][] (array of arrays) and return
            return mapList.ToArray();

        }
    /*
    public static string GetMapEditor()
    {
        string[] mapsList = System.IO.Directory.GetFiles(Directory.GetCurrentDirectory() + "/Assets/Resources/Maps");

        List<string> mapsList2 = new List<string>();
        for (int i = 0; i < mapsList.Length; i++)
        {
            if (!mapsList[i].Contains(".meta"))
                mapsList2.Add(mapsList[i]);
        }
        string str = mapsList[mapsList.Length - 1];
        string maptxt = str.Substring(str.Length - 5);
        return maptxt[0].ToString();
    }*/

    public static string GetMapEditor()
    {
        string[] mapsList = System.IO.Directory.GetFiles(Directory.GetCurrentDirectory() + "/Assets/Resources/Maps");

        List<string> mapsList2 = new List<string>();
        for (int i = 0; i < mapsList.Length; i++)
        {
            if (!mapsList[i].Contains(".meta"))
                mapsList2.Add(mapsList[i]);
        }
        string str = mapsList2[mapsList2.Count - 1];
        Console.WriteLine(str);
        string maptxt = str.Substring(str.Length - 5);
        return maptxt[0].ToString();
    }

    private void Awake()
    {

    }

    void Start()
    {
        EditorGenMap();
    }

}

