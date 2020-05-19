using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            GameObject projectile = Instantiate(bullet) as GameObject;
            projectile.transform.position = GameObject.Find("Player").transform.position - new Vector3(0, 0, 0) + GameObject.Find("Player").transform.right;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = GameObject.Find("Player").transform.right * 4;
        }
    }
}
