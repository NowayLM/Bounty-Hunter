using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPoints : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        GameObject.Find("HP").transform.position = GameObject.Find("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("HP").transform.position = new Vector3(GameObject.Find("Player").transform.position.x + 1, GameObject.Find("Player").transform.position.y + 1f, GameObject.Find("Player").transform.position.z + 0.75f);
    }
}
