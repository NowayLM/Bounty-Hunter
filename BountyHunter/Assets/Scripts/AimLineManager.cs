using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimLineManager : MonoBehaviour
{

    protected LineRenderer aim;
    
    // Start is called before the first frame update
    void Start()
    {
        aim = GetComponent<LineRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        var points = new Vector3[1];
        points[0] = GameObject.Find("Player").transform.position;
        points[1] = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        aim.SetPositions(points);
    }
}
