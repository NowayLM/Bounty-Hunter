using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject sniper;
    public GameObject wave;
    public GameObject mortar;
    public int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (!GameModelsContainer.models[i].activeSelf)
        {
            i += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            if (GameModelsContainer.models[i].name == "Daeodon")
            {
                GameObject projectile = Instantiate(mortar) as GameObject;
                projectile.transform.position = GameObject.Find("Player").transform.position - new Vector3(0, 0, 0) + GameObject.Find("Player").transform.right;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = (GameObject.Find("Player").transform.right + new Vector3(0, 1.25f, 0)) * 7;
            }
            else if (GameModelsContainer.models[i].name == "Hawk")
            {
                GameObject projectile = Instantiate(sniper) as GameObject;
                projectile.transform.position = GameObject.Find("Player").transform.position - new Vector3(0, 0, 0) + GameObject.Find("Player").transform.right;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                projectile.transform.rotation = GameObject.Find("Player").transform.rotation;
                rb.velocity = GameObject.Find("Player").transform.right * 18;
            }
            else if (GameModelsContainer.models[i].name == "Sonos")
            {
                GameObject projectile = Instantiate(wave) as GameObject;
                projectile.transform.position = GameObject.Find("Player").transform.position - new Vector3(0, .3f, 0) + GameObject.Find("Player").transform.right;
            }
            else if (GameModelsContainer.models[i].name == "Tanky")
            {
                GameObject projectile = Instantiate(bullet) as GameObject;
                projectile.transform.position = GameObject.Find("Player").transform.position - new Vector3(0, 0, 0) + GameObject.Find("Player").transform.right;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = GameObject.Find("Player").transform.right * 7;
            }
            else if (GameModelsContainer.models[i].name == "Chevro")
            {
                GameObject projectile = Instantiate(bullet) as GameObject;
                projectile.transform.position = GameObject.Find("Player").transform.position - new Vector3(0, 0, 0) + GameObject.Find("Player").transform.right;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = GameObject.Find("Player").transform.right * 7;
            }
        }
    }
}
