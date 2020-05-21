using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Camera.main.enabled = true;
        Camera.main.transform.position = new Vector3(-12.5f, 13, -9.6f);
    }

    // Update is called once per frame
    float Cx = new float();
    float Cy = new float();
    float Cz = new float();
    void Update()
    {
        Cx = Camera.main.transform.position.x;
        Cy = Camera.main.transform.position.y;
        Cz = Camera.main.transform.position.z;
        Camera.main.transform.position = new Vector3(((GameObject.Find("Player").transform.position.x + (Cx * 3))/4) - 1f, Cy, Cz);

        if (Camera.main.transform.position.x < -12.5f)
        {
            Cy = Camera.main.transform.position.y;
            Cz = Camera.main.transform.position.z;
            Camera.main.transform.position = new Vector3(-12.5f, Cy, Cz);
        }
        else
        {
            if (Camera.main.transform.position.x > 1.5f)
            {
                Cy = Camera.main.transform.position.y;
                Cz = Camera.main.transform.position.z;
                Camera.main.transform.position = new Vector3(1.5f, Cy, Cz);
            }
        }
    }
}
