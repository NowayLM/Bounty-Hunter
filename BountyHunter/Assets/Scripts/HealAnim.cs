using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealAnim : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 initPos;
    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = initPos + new Vector3(0, Convert.ToSingle(Math.Sin(Time.time)) / 5, 0);
        transform.rotation = Quaternion.Euler(0, Time.time * 50, 0);
    }
}
