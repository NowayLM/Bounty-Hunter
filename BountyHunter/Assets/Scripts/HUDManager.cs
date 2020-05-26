using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int sec = 60;
    public static float timer = 0;
    public static bool timeStarted = false;
    public string str;
    private GUIStyle guiStyle = new GUIStyle();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timer = Time.time;
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        str = string.Format("{0}:{1}", minutes, seconds);
        if(minutes == "2")
        {
            Application.Quit();
        }

    }
    void OnGUI()
    {
        guiStyle.fontSize = 35;
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");
        GUI.Label(new Rect(430, 5, 500, 100), str, guiStyle);
    }
}
