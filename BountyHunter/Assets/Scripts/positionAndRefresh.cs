using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionAndRefresh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Top left").transform.position = new Vector3(GameObject.Find("Player").transform.position.x + 5f, 2f, -1f);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Top left").transform.position = new Vector3(GameObject.Find("Player").transform.position.x + 5f, 2f, -1f);
    }
}
