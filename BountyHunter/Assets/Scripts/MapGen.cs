using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MapGen : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform tilePrefab;
    [Range(0,1)]
    public float outlinePercent;

    public void GenMap()
    {
        char[,] arr = fun("1");
        for (int x = 0; x < arr.GetLength(0); x++)
        {
            for (int y = 0; y < arr.GetLength(1); y++)
            {
                Vector3 tilePosition = new Vector3(-arr.GetLength(0) / 2 + 0.5f + x, 0, -arr.GetLength(1) + 0.5f + y);
                Transform newTile = Instantiate(tilePrefab, tilePosition, Quaternion.Euler(Vector3.right * 90)) as Transform;
                newTile.localScale = Vector3.one * (1 - outlinePercent);
            }

        }
    }

    public static char[,] fun(string map)
    {
        using (StreamReader sr = File.OpenText($"C:\\Users\\lance\\Dev\\EPITA\\PROJET S2\\BountyHunter\\Maps\\{map}.txt"))
        {
            string s = "";
            s = sr.ReadLine();
            int l = new int();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ';')
                {
                    l++;
                }
            }
            int width = 0;
            int m = 1;
            while (s[m] != ';')
            {
                if (s[m] != ',')
                {
                    width++;
                }
                m++;
            }

            char[,] arr = new char[l,width];
            int k = new int();
            int j = new int();
            foreach (char i in s)
            {
                if (!(i == ';'))
                {
                    arr[k, j] = i;
                    j++;
                }
                else
                {
                    k++;
                    j = 0;
                }
            }
            return arr;
        }
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
