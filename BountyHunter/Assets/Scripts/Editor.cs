using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Windows;
using System.Text;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class Editor : MonoBehaviour
{
    public InputField inputField;
    // Need to change the path as it doesnt work for the .exe
    public static string str = GetMapName();
    public static string GetMapName()
    {
        string[] mapsList = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "/Assets/Resources/Maps");
        List<int> mapsList2 = new List<int>();
        int res = 0;
        for (int i = 0; i < mapsList.Length; i++)
        {
            if (!mapsList[i].Contains(".meta"))
                res++;
        }
        int mapnb = res + 1;
        str = mapnb.ToString();
        string path = System.IO.Directory.GetCurrentDirectory() + "/Assets/Resources/Maps/" + mapnb.ToString() + ".txt";
        return path;
    }


    public void SaveTheMap(string[] res)
    {
        using (System.IO.FileStream fs = System.IO.File.Create(GetMapName()))
        {
            foreach (string line in res)
            {
                byte[] lineB = new UTF8Encoding(true).GetBytes(line);
                fs.Write(lineB, 0, lineB.Length);
            }
        }
    }

    public static void SaveMapUnity(string path)
    {
        #if UNITY_EDITOR
            Byte[] content = File.ReadAllBytes(path);
            File.WriteAllBytes(path, content);
        #endif
    }

    public void LoadEditorScene()
    {
        SceneManager.LoadScene(5);
    }

    public static int nblines = 0;
    public List<string> res = new List<string>();

    public void GetInput(InputField inputField)
    {
        if (nblines < 25)
        {
            string str = inputField.text + "\r\n";
            res.Add(str);
            nblines++;
        }
        else
        {
            string[] map = res.ToArray();
            string mapPath = GetMapName();
            SaveTheMap(map);
            SaveMapUnity(mapPath);
            #if UNITY_EDITOR
                AssetDatabase.Refresh();
            #endif
            SceneManager.LoadScene(6);
        }
    }

    public void ClearInputField(InputField inputField)
    {
        inputField.text = "";
    }
}
