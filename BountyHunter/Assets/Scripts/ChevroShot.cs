using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChevroShot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject chevroShot;
    /*void Start()
    {
        GameObject projectile = Instantiate(chevroShot) as GameObject;
        projectile.transform.position = GameObject.Find("Player").transform.position - new Vector3(0, 0, 0) + GameObject.Find("Player").transform.right;
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = (transform.right + new Vector3(0.2f, 0, 0)) * 10;
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
