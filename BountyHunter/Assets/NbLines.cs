using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NbLines : MonoBehaviour
{
    public void IncrementLines(Text text)
    {
        int l = text.text.ToString().Length;
        string sub = (text.text.ToString()).Substring(0,7);
        string sub2 = "";
        string str = text.text.ToString();
        string nblines = str[l - 1].ToString();
        int newInt = Convert.ToInt32(nblines);
        if (newInt == 9 && str[l - 2].ToString() == "°")
        {
            newInt = 10;
            sub += newInt.ToString();
            text.text = sub;
        }
        else
        {
            if (newInt == 9 && str[l - 2].ToString() == "1")
            {
                newInt = 20;
                sub += newInt.ToString();
                text.text = sub;
            }
            else
            {
                if(str[l - 2].ToString() == "1" || str[l - 2].ToString() == "2")
                {
                    sub2 = text.text.ToString().Substring(0, 8);
                    newInt++;
                    sub2 += newInt.ToString();
                    text.text = sub2;
                }
                else
                {
                    if(str[l - 1].ToString() == "5" && str[l - 2].ToString() == "2")
                    {
                        text.text = "Enter any number to load the map !";
                    }
                    else
                    {
                        newInt++;
                        sub += newInt.ToString();
                        text.text = sub;
                    }
                }
            }
        }
    }
}
